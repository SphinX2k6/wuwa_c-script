using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001070 RID: 4208
	[NetMessage(EMessageId.RoleGiftRewardRequest)]
	public sealed class RoleGiftRewardRequest : IMessage<RoleGiftRewardRequest>, IMessage, IEquatable<RoleGiftRewardRequest>, IDeepCloneable<RoleGiftRewardRequest>, IBufferMessage
	{
		// Token: 0x06016827 RID: 92199 RVA: 0x0034629C File Offset: 0x0034449C
		[NullableContext(1)]
		public static RoleGiftRewardRequest Create()
		{
			return new RoleGiftRewardRequest();
		}

		// Token: 0x17004B62 RID: 19298
		// (get) Token: 0x06016828 RID: 92200 RVA: 0x003462A3 File Offset: 0x003444A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B63 RID: 19299
		// (get) Token: 0x06016829 RID: 92201 RVA: 0x003462A6 File Offset: 0x003444A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleGiftRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601682A RID: 92202 RVA: 0x003462AD File Offset: 0x003444AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGiftRewardRequest()
		{
		}

		// Token: 0x0601682B RID: 92203 RVA: 0x003462B5 File Offset: 0x003444B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGiftRewardRequest(RoleGiftRewardRequest other) : this()
		{
			this.taskId_ = other.taskId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601682C RID: 92204 RVA: 0x003462DA File Offset: 0x003444DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleGiftRewardRequest Clone()
		{
			return new RoleGiftRewardRequest(this);
		}

		// Token: 0x17004B64 RID: 19300
		// (get) Token: 0x0601682D RID: 92205 RVA: 0x003462E2 File Offset: 0x003444E2
		// (set) Token: 0x0601682E RID: 92206 RVA: 0x003462EA File Offset: 0x003444EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TaskId
		{
			get
			{
				return this.taskId_;
			}
			set
			{
				this.taskId_ = value;
			}
		}

		// Token: 0x0601682F RID: 92207 RVA: 0x003462F3 File Offset: 0x003444F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleGiftRewardRequest);
		}

		// Token: 0x06016830 RID: 92208 RVA: 0x00346301 File Offset: 0x00344501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleGiftRewardRequest other)
		{
			return other != null && (other == this || (this.TaskId == other.TaskId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016831 RID: 92209 RVA: 0x00346330 File Offset: 0x00344530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TaskId != 0)
			{
				num ^= this.TaskId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016832 RID: 92210 RVA: 0x0034636F File Offset: 0x0034456F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016833 RID: 92211 RVA: 0x0034637C File Offset: 0x0034457C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016834 RID: 92212 RVA: 0x00346385 File Offset: 0x00344585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TaskId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.TaskId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016835 RID: 92213 RVA: 0x003463B8 File Offset: 0x003445B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TaskId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TaskId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016836 RID: 92214 RVA: 0x003463F6 File Offset: 0x003445F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleGiftRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TaskId != 0)
			{
				this.TaskId = other.TaskId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016837 RID: 92215 RVA: 0x00346427 File Offset: 0x00344627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016838 RID: 92216 RVA: 0x00346430 File Offset: 0x00344630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TaskId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008703 RID: 34563
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008704 RID: 34564
		public const int TaskIdFieldNumber = 10;

		// Token: 0x04008705 RID: 34565
		private int taskId_;
	}
}

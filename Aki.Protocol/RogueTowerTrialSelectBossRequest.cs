using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001013 RID: 4115
	[NetMessage(EMessageId.RogueTowerTrialSelectBossRequest)]
	public sealed class RogueTowerTrialSelectBossRequest : IMessage<RogueTowerTrialSelectBossRequest>, IMessage, IEquatable<RogueTowerTrialSelectBossRequest>, IDeepCloneable<RogueTowerTrialSelectBossRequest>, IBufferMessage
	{
		// Token: 0x0601606D RID: 90221 RVA: 0x00334205 File Offset: 0x00332405
		[NullableContext(1)]
		public static RogueTowerTrialSelectBossRequest Create()
		{
			return new RogueTowerTrialSelectBossRequest();
		}

		// Token: 0x170049A6 RID: 18854
		// (get) Token: 0x0601606E RID: 90222 RVA: 0x0033420C File Offset: 0x0033240C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049A7 RID: 18855
		// (get) Token: 0x0601606F RID: 90223 RVA: 0x0033420F File Offset: 0x0033240F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialSelectBossRequest.Descriptor;
			}
		}

		// Token: 0x06016070 RID: 90224 RVA: 0x00334216 File Offset: 0x00332416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialSelectBossRequest()
		{
		}

		// Token: 0x06016071 RID: 90225 RVA: 0x0033421E File Offset: 0x0033241E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialSelectBossRequest(RogueTowerTrialSelectBossRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016072 RID: 90226 RVA: 0x00334243 File Offset: 0x00332443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialSelectBossRequest Clone()
		{
			return new RogueTowerTrialSelectBossRequest(this);
		}

		// Token: 0x170049A8 RID: 18856
		// (get) Token: 0x06016073 RID: 90227 RVA: 0x0033424B File Offset: 0x0033244B
		// (set) Token: 0x06016074 RID: 90228 RVA: 0x00334253 File Offset: 0x00332453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06016075 RID: 90229 RVA: 0x0033425C File Offset: 0x0033245C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialSelectBossRequest);
		}

		// Token: 0x06016076 RID: 90230 RVA: 0x0033426A File Offset: 0x0033246A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialSelectBossRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016077 RID: 90231 RVA: 0x00334298 File Offset: 0x00332498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016078 RID: 90232 RVA: 0x003342D7 File Offset: 0x003324D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016079 RID: 90233 RVA: 0x003342E4 File Offset: 0x003324E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601607A RID: 90234 RVA: 0x003342ED File Offset: 0x003324ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601607B RID: 90235 RVA: 0x00334320 File Offset: 0x00332520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601607C RID: 90236 RVA: 0x0033435E File Offset: 0x0033255E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTowerTrialSelectBossRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601607D RID: 90237 RVA: 0x0033438F File Offset: 0x0033258F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601607E RID: 90238 RVA: 0x00334398 File Offset: 0x00332598
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400847E RID: 33918
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400847F RID: 33919
		public const int IdFieldNumber = 13;

		// Token: 0x04008480 RID: 33920
		private int id_;
	}
}

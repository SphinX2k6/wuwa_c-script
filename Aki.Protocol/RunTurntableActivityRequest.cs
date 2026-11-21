using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001179 RID: 4473
	[NetMessage(EMessageId.RunTurntableActivityRequest)]
	public sealed class RunTurntableActivityRequest : IMessage<RunTurntableActivityRequest>, IMessage, IEquatable<RunTurntableActivityRequest>, IDeepCloneable<RunTurntableActivityRequest>, IBufferMessage
	{
		// Token: 0x06017E4D RID: 97869 RVA: 0x0037A4A5 File Offset: 0x003786A5
		[NullableContext(1)]
		public static RunTurntableActivityRequest Create()
		{
			return new RunTurntableActivityRequest();
		}

		// Token: 0x1700506D RID: 20589
		// (get) Token: 0x06017E4E RID: 97870 RVA: 0x0037A4AC File Offset: 0x003786AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700506E RID: 20590
		// (get) Token: 0x06017E4F RID: 97871 RVA: 0x0037A4AF File Offset: 0x003786AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RunTurntableActivityRequest.Descriptor;
			}
		}

		// Token: 0x06017E50 RID: 97872 RVA: 0x0037A4B6 File Offset: 0x003786B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RunTurntableActivityRequest()
		{
		}

		// Token: 0x06017E51 RID: 97873 RVA: 0x0037A4BE File Offset: 0x003786BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RunTurntableActivityRequest(RunTurntableActivityRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017E52 RID: 97874 RVA: 0x0037A4E3 File Offset: 0x003786E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RunTurntableActivityRequest Clone()
		{
			return new RunTurntableActivityRequest(this);
		}

		// Token: 0x1700506F RID: 20591
		// (get) Token: 0x06017E53 RID: 97875 RVA: 0x0037A4EB File Offset: 0x003786EB
		// (set) Token: 0x06017E54 RID: 97876 RVA: 0x0037A4F3 File Offset: 0x003786F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x06017E55 RID: 97877 RVA: 0x0037A4FC File Offset: 0x003786FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RunTurntableActivityRequest);
		}

		// Token: 0x06017E56 RID: 97878 RVA: 0x0037A50A File Offset: 0x0037870A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RunTurntableActivityRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017E57 RID: 97879 RVA: 0x0037A538 File Offset: 0x00378738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017E58 RID: 97880 RVA: 0x0037A577 File Offset: 0x00378777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017E59 RID: 97881 RVA: 0x0037A584 File Offset: 0x00378784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017E5A RID: 97882 RVA: 0x0037A58D File Offset: 0x0037878D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017E5B RID: 97883 RVA: 0x0037A5C0 File Offset: 0x003787C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017E5C RID: 97884 RVA: 0x0037A5FE File Offset: 0x003787FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RunTurntableActivityRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017E5D RID: 97885 RVA: 0x0037A62F File Offset: 0x0037882F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017E5E RID: 97886 RVA: 0x0037A638 File Offset: 0x00378838
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008E68 RID: 36456
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E69 RID: 36457
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04008E6A RID: 36458
		private int activityId_;
	}
}

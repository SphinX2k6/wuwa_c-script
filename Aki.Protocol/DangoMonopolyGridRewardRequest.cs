using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000387 RID: 903
	[NetMessage(EMessageId.DangoMonopolyGridRewardRequest)]
	public sealed class DangoMonopolyGridRewardRequest : IMessage<DangoMonopolyGridRewardRequest>, IMessage, IEquatable<DangoMonopolyGridRewardRequest>, IDeepCloneable<DangoMonopolyGridRewardRequest>, IBufferMessage
	{
		// Token: 0x0600595B RID: 22875 RVA: 0x000D9B4D File Offset: 0x000D7D4D
		[NullableContext(1)]
		public static DangoMonopolyGridRewardRequest Create()
		{
			return new DangoMonopolyGridRewardRequest();
		}

		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x0600595C RID: 22876 RVA: 0x000D9B54 File Offset: 0x000D7D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x0600595D RID: 22877 RVA: 0x000D9B57 File Offset: 0x000D7D57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyGridRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600595E RID: 22878 RVA: 0x000D9B5E File Offset: 0x000D7D5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyGridRewardRequest()
		{
		}

		// Token: 0x0600595F RID: 22879 RVA: 0x000D9B66 File Offset: 0x000D7D66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyGridRewardRequest(DangoMonopolyGridRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005960 RID: 22880 RVA: 0x000D9B8B File Offset: 0x000D7D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyGridRewardRequest Clone()
		{
			return new DangoMonopolyGridRewardRequest(this);
		}

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x06005961 RID: 22881 RVA: 0x000D9B93 File Offset: 0x000D7D93
		// (set) Token: 0x06005962 RID: 22882 RVA: 0x000D9B9B File Offset: 0x000D7D9B
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

		// Token: 0x06005963 RID: 22883 RVA: 0x000D9BA4 File Offset: 0x000D7DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyGridRewardRequest);
		}

		// Token: 0x06005964 RID: 22884 RVA: 0x000D9BB2 File Offset: 0x000D7DB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyGridRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005965 RID: 22885 RVA: 0x000D9BE0 File Offset: 0x000D7DE0
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

		// Token: 0x06005966 RID: 22886 RVA: 0x000D9C1F File Offset: 0x000D7E1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005967 RID: 22887 RVA: 0x000D9C2C File Offset: 0x000D7E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005968 RID: 22888 RVA: 0x000D9C35 File Offset: 0x000D7E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005969 RID: 22889 RVA: 0x000D9C68 File Offset: 0x000D7E68
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

		// Token: 0x0600596A RID: 22890 RVA: 0x000D9CA6 File Offset: 0x000D7EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyGridRewardRequest other)
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

		// Token: 0x0600596B RID: 22891 RVA: 0x000D9CD7 File Offset: 0x000D7ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600596C RID: 22892 RVA: 0x000D9CE0 File Offset: 0x000D7EE0
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003561 RID: 13665
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003562 RID: 13666
		public const int ActivityIdFieldNumber = 11;

		// Token: 0x04003563 RID: 13667
		private int activityId_;
	}
}

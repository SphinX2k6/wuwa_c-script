using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005D6 RID: 1494
	[NetMessage(EMessageId.FloroRanchPlayUnlimitedModeRequest)]
	public sealed class FloroRanchPlayUnlimitedModeRequest : IMessage<FloroRanchPlayUnlimitedModeRequest>, IMessage, IEquatable<FloroRanchPlayUnlimitedModeRequest>, IDeepCloneable<FloroRanchPlayUnlimitedModeRequest>, IBufferMessage
	{
		// Token: 0x06008A49 RID: 35401 RVA: 0x0014E6E5 File Offset: 0x0014C8E5
		[NullableContext(1)]
		public static FloroRanchPlayUnlimitedModeRequest Create()
		{
			return new FloroRanchPlayUnlimitedModeRequest();
		}

		// Token: 0x17001B43 RID: 6979
		// (get) Token: 0x06008A4A RID: 35402 RVA: 0x0014E6EC File Offset: 0x0014C8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B44 RID: 6980
		// (get) Token: 0x06008A4B RID: 35403 RVA: 0x0014E6EF File Offset: 0x0014C8EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayUnlimitedModeRequest.Descriptor;
			}
		}

		// Token: 0x06008A4C RID: 35404 RVA: 0x0014E6F6 File Offset: 0x0014C8F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayUnlimitedModeRequest()
		{
		}

		// Token: 0x06008A4D RID: 35405 RVA: 0x0014E6FE File Offset: 0x0014C8FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayUnlimitedModeRequest(FloroRanchPlayUnlimitedModeRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008A4E RID: 35406 RVA: 0x0014E72F File Offset: 0x0014C92F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayUnlimitedModeRequest Clone()
		{
			return new FloroRanchPlayUnlimitedModeRequest(this);
		}

		// Token: 0x17001B45 RID: 6981
		// (get) Token: 0x06008A4F RID: 35407 RVA: 0x0014E737 File Offset: 0x0014C937
		// (set) Token: 0x06008A50 RID: 35408 RVA: 0x0014E73F File Offset: 0x0014C93F
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

		// Token: 0x17001B46 RID: 6982
		// (get) Token: 0x06008A51 RID: 35409 RVA: 0x0014E748 File Offset: 0x0014C948
		// (set) Token: 0x06008A52 RID: 35410 RVA: 0x0014E750 File Offset: 0x0014C950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubInsId
		{
			get
			{
				return this.subInsId_;
			}
			set
			{
				this.subInsId_ = value;
			}
		}

		// Token: 0x06008A53 RID: 35411 RVA: 0x0014E759 File Offset: 0x0014C959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayUnlimitedModeRequest);
		}

		// Token: 0x06008A54 RID: 35412 RVA: 0x0014E767 File Offset: 0x0014C967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayUnlimitedModeRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008A55 RID: 35413 RVA: 0x0014E7A8 File Offset: 0x0014C9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.SubInsId != 0)
			{
				num ^= this.SubInsId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008A56 RID: 35414 RVA: 0x0014E800 File Offset: 0x0014CA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008A57 RID: 35415 RVA: 0x0014E80D File Offset: 0x0014CA0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008A58 RID: 35416 RVA: 0x0014E818 File Offset: 0x0014CA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SubInsId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008A59 RID: 35417 RVA: 0x0014E874 File Offset: 0x0014CA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubInsId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008A5A RID: 35418 RVA: 0x0014E8CC File Offset: 0x0014CACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayUnlimitedModeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.SubInsId != 0)
			{
				this.SubInsId = other.SubInsId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008A5B RID: 35419 RVA: 0x0014E91C File Offset: 0x0014CB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008A5C RID: 35420 RVA: 0x0014E928 File Offset: 0x0014CB28
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
				if (num != 16U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.SubInsId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040043F8 RID: 17400
		private UnknownFieldSet _unknownFields;

		// Token: 0x040043F9 RID: 17401
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x040043FA RID: 17402
		private int activityId_;

		// Token: 0x040043FB RID: 17403
		public const int SubInsIdFieldNumber = 2;

		// Token: 0x040043FC RID: 17404
		private int subInsId_;
	}
}

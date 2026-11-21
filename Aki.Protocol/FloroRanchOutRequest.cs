using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005A0 RID: 1440
	[NetMessage(EMessageId.FloroRanchOutRequest)]
	public sealed class FloroRanchOutRequest : IMessage<FloroRanchOutRequest>, IMessage, IEquatable<FloroRanchOutRequest>, IDeepCloneable<FloroRanchOutRequest>, IBufferMessage
	{
		// Token: 0x0600858F RID: 34191 RVA: 0x0014197F File Offset: 0x0013FB7F
		[NullableContext(1)]
		public static FloroRanchOutRequest Create()
		{
			return new FloroRanchOutRequest();
		}

		// Token: 0x17001A0C RID: 6668
		// (get) Token: 0x06008590 RID: 34192 RVA: 0x00141986 File Offset: 0x0013FB86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A0D RID: 6669
		// (get) Token: 0x06008591 RID: 34193 RVA: 0x00141989 File Offset: 0x0013FB89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchOutRequest.Descriptor;
			}
		}

		// Token: 0x06008592 RID: 34194 RVA: 0x00141990 File Offset: 0x0013FB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchOutRequest()
		{
		}

		// Token: 0x06008593 RID: 34195 RVA: 0x00141998 File Offset: 0x0013FB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchOutRequest(FloroRanchOutRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008594 RID: 34196 RVA: 0x001419C9 File Offset: 0x0013FBC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchOutRequest Clone()
		{
			return new FloroRanchOutRequest(this);
		}

		// Token: 0x17001A0E RID: 6670
		// (get) Token: 0x06008595 RID: 34197 RVA: 0x001419D1 File Offset: 0x0013FBD1
		// (set) Token: 0x06008596 RID: 34198 RVA: 0x001419D9 File Offset: 0x0013FBD9
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

		// Token: 0x17001A0F RID: 6671
		// (get) Token: 0x06008597 RID: 34199 RVA: 0x001419E2 File Offset: 0x0013FBE2
		// (set) Token: 0x06008598 RID: 34200 RVA: 0x001419EA File Offset: 0x0013FBEA
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

		// Token: 0x06008599 RID: 34201 RVA: 0x001419F3 File Offset: 0x0013FBF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchOutRequest);
		}

		// Token: 0x0600859A RID: 34202 RVA: 0x00141A01 File Offset: 0x0013FC01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchOutRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600859B RID: 34203 RVA: 0x00141A40 File Offset: 0x0013FC40
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

		// Token: 0x0600859C RID: 34204 RVA: 0x00141A98 File Offset: 0x0013FC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600859D RID: 34205 RVA: 0x00141AA5 File Offset: 0x0013FCA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600859E RID: 34206 RVA: 0x00141AB0 File Offset: 0x0013FCB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(24);
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

		// Token: 0x0600859F RID: 34207 RVA: 0x00141B0C File Offset: 0x0013FD0C
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

		// Token: 0x060085A0 RID: 34208 RVA: 0x00141B64 File Offset: 0x0013FD64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchOutRequest other)
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

		// Token: 0x060085A1 RID: 34209 RVA: 0x00141BB4 File Offset: 0x0013FDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060085A2 RID: 34210 RVA: 0x00141BC0 File Offset: 0x0013FDC0
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
				if (num != 24U)
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

		// Token: 0x04004272 RID: 17010
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004273 RID: 17011
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x04004274 RID: 17012
		private int activityId_;

		// Token: 0x04004275 RID: 17013
		public const int SubInsIdFieldNumber = 3;

		// Token: 0x04004276 RID: 17014
		private int subInsId_;
	}
}

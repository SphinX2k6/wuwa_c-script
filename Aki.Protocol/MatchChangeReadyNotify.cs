using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009B0 RID: 2480
	[NetMessage(EMessageId.MatchChangeReadyNotify)]
	public sealed class MatchChangeReadyNotify : IMessage<MatchChangeReadyNotify>, IMessage, IEquatable<MatchChangeReadyNotify>, IDeepCloneable<MatchChangeReadyNotify>, IBufferMessage
	{
		// Token: 0x0600D9B1 RID: 55729 RVA: 0x001FF965 File Offset: 0x001FDB65
		[NullableContext(1)]
		public static MatchChangeReadyNotify Create()
		{
			return new MatchChangeReadyNotify();
		}

		// Token: 0x17002C17 RID: 11287
		// (get) Token: 0x0600D9B2 RID: 55730 RVA: 0x001FF96C File Offset: 0x001FDB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C18 RID: 11288
		// (get) Token: 0x0600D9B3 RID: 55731 RVA: 0x001FF96F File Offset: 0x001FDB6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchChangeReadyNotify.Descriptor;
			}
		}

		// Token: 0x0600D9B4 RID: 55732 RVA: 0x001FF976 File Offset: 0x001FDB76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeReadyNotify()
		{
		}

		// Token: 0x0600D9B5 RID: 55733 RVA: 0x001FF97E File Offset: 0x001FDB7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeReadyNotify(MatchChangeReadyNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.isReady_ = other.isReady_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D9B6 RID: 55734 RVA: 0x001FF9AF File Offset: 0x001FDBAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangeReadyNotify Clone()
		{
			return new MatchChangeReadyNotify(this);
		}

		// Token: 0x17002C19 RID: 11289
		// (get) Token: 0x0600D9B7 RID: 55735 RVA: 0x001FF9B7 File Offset: 0x001FDBB7
		// (set) Token: 0x0600D9B8 RID: 55736 RVA: 0x001FF9BF File Offset: 0x001FDBBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17002C1A RID: 11290
		// (get) Token: 0x0600D9B9 RID: 55737 RVA: 0x001FF9C8 File Offset: 0x001FDBC8
		// (set) Token: 0x0600D9BA RID: 55738 RVA: 0x001FF9D0 File Offset: 0x001FDBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsReady
		{
			get
			{
				return this.isReady_;
			}
			set
			{
				this.isReady_ = value;
			}
		}

		// Token: 0x0600D9BB RID: 55739 RVA: 0x001FF9D9 File Offset: 0x001FDBD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchChangeReadyNotify);
		}

		// Token: 0x0600D9BC RID: 55740 RVA: 0x001FF9E7 File Offset: 0x001FDBE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchChangeReadyNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.IsReady == other.IsReady && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D9BD RID: 55741 RVA: 0x001FFA28 File Offset: 0x001FDC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.IsReady)
			{
				num ^= this.IsReady.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D9BE RID: 55742 RVA: 0x001FFA80 File Offset: 0x001FDC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D9BF RID: 55743 RVA: 0x001FFA8D File Offset: 0x001FDC8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D9C0 RID: 55744 RVA: 0x001FFA98 File Offset: 0x001FDC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsReady)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsReady);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D9C1 RID: 55745 RVA: 0x001FFAF4 File Offset: 0x001FDCF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.IsReady)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D9C2 RID: 55746 RVA: 0x001FFB40 File Offset: 0x001FDD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchChangeReadyNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.IsReady)
			{
				this.IsReady = other.IsReady;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D9C3 RID: 55747 RVA: 0x001FFB90 File Offset: 0x001FDD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D9C4 RID: 55748 RVA: 0x001FFB9C File Offset: 0x001FDD9C
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
				if (num != 40U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.IsReady = input.ReadBool();
				}
			}
		}

		// Token: 0x04005A85 RID: 23173
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A86 RID: 23174
		public const int PlayerIdFieldNumber = 12;

		// Token: 0x04005A87 RID: 23175
		private int playerId_;

		// Token: 0x04005A88 RID: 23176
		public const int IsReadyFieldNumber = 5;

		// Token: 0x04005A89 RID: 23177
		private bool isReady_;
	}
}

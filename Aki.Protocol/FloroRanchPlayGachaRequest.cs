using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005BE RID: 1470
	[NetMessage(EMessageId.FloroRanchPlayGachaRequest)]
	public sealed class FloroRanchPlayGachaRequest : IMessage<FloroRanchPlayGachaRequest>, IMessage, IEquatable<FloroRanchPlayGachaRequest>, IDeepCloneable<FloroRanchPlayGachaRequest>, IBufferMessage
	{
		// Token: 0x060087CB RID: 34763 RVA: 0x00146BA7 File Offset: 0x00144DA7
		[NullableContext(1)]
		public static FloroRanchPlayGachaRequest Create()
		{
			return new FloroRanchPlayGachaRequest();
		}

		// Token: 0x17001A92 RID: 6802
		// (get) Token: 0x060087CC RID: 34764 RVA: 0x00146BAE File Offset: 0x00144DAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A93 RID: 6803
		// (get) Token: 0x060087CD RID: 34765 RVA: 0x00146BB1 File Offset: 0x00144DB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayGachaRequest.Descriptor;
			}
		}

		// Token: 0x060087CE RID: 34766 RVA: 0x00146BB8 File Offset: 0x00144DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGachaRequest()
		{
		}

		// Token: 0x060087CF RID: 34767 RVA: 0x00146BC0 File Offset: 0x00144DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGachaRequest(FloroRanchPlayGachaRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this.cardId_ = other.cardId_;
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060087D0 RID: 34768 RVA: 0x00146C14 File Offset: 0x00144E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGachaRequest Clone()
		{
			return new FloroRanchPlayGachaRequest(this);
		}

		// Token: 0x17001A94 RID: 6804
		// (get) Token: 0x060087D1 RID: 34769 RVA: 0x00146C1C File Offset: 0x00144E1C
		// (set) Token: 0x060087D2 RID: 34770 RVA: 0x00146C24 File Offset: 0x00144E24
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

		// Token: 0x17001A95 RID: 6805
		// (get) Token: 0x060087D3 RID: 34771 RVA: 0x00146C2D File Offset: 0x00144E2D
		// (set) Token: 0x060087D4 RID: 34772 RVA: 0x00146C35 File Offset: 0x00144E35
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

		// Token: 0x17001A96 RID: 6806
		// (get) Token: 0x060087D5 RID: 34773 RVA: 0x00146C3E File Offset: 0x00144E3E
		// (set) Token: 0x060087D6 RID: 34774 RVA: 0x00146C46 File Offset: 0x00144E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardId
		{
			get
			{
				return this.cardId_;
			}
			set
			{
				this.cardId_ = value;
			}
		}

		// Token: 0x17001A97 RID: 6807
		// (get) Token: 0x060087D7 RID: 34775 RVA: 0x00146C4F File Offset: 0x00144E4F
		// (set) Token: 0x060087D8 RID: 34776 RVA: 0x00146C57 File Offset: 0x00144E57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x060087D9 RID: 34777 RVA: 0x00146C60 File Offset: 0x00144E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayGachaRequest);
		}

		// Token: 0x060087DA RID: 34778 RVA: 0x00146C70 File Offset: 0x00144E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayGachaRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && this.CardId == other.CardId && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060087DB RID: 34779 RVA: 0x00146CDC File Offset: 0x00144EDC
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
			if (this.CardId != 0)
			{
				num ^= this.CardId.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060087DC RID: 34780 RVA: 0x00146D66 File Offset: 0x00144F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060087DD RID: 34781 RVA: 0x00146D73 File Offset: 0x00144F73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060087DE RID: 34782 RVA: 0x00146D7C File Offset: 0x00144F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CardId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.IncId);
			}
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.SubInsId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060087DF RID: 34783 RVA: 0x00146E10 File Offset: 0x00145010
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
			if (this.CardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardId);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060087E0 RID: 34784 RVA: 0x00146E98 File Offset: 0x00145098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayGachaRequest other)
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
			if (other.CardId != 0)
			{
				this.CardId = other.CardId;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060087E1 RID: 34785 RVA: 0x00146F10 File Offset: 0x00145110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060087E2 RID: 34786 RVA: 0x00146F1C File Offset: 0x0014511C
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
				if (num <= 24U)
				{
					if (num == 16U)
					{
						this.CardId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.IncId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.SubInsId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040042DE RID: 17118
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042DF RID: 17119
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x040042E0 RID: 17120
		private int activityId_;

		// Token: 0x040042E1 RID: 17121
		public const int SubInsIdFieldNumber = 14;

		// Token: 0x040042E2 RID: 17122
		private int subInsId_;

		// Token: 0x040042E3 RID: 17123
		public const int CardIdFieldNumber = 2;

		// Token: 0x040042E4 RID: 17124
		private int cardId_;

		// Token: 0x040042E5 RID: 17125
		public const int IncIdFieldNumber = 10;

		// Token: 0x040042E6 RID: 17126
		private int incId_;
	}
}

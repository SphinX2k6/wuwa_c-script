using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001434 RID: 5172
	[NetMessage(EMessageId.TowerInfoUpdateNotify)]
	public sealed class TowerInfoUpdateNotify : IMessage<TowerInfoUpdateNotify>, IMessage, IEquatable<TowerInfoUpdateNotify>, IDeepCloneable<TowerInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601B7C1 RID: 112577 RVA: 0x003FEE4A File Offset: 0x003FD04A
		[NullableContext(1)]
		public static TowerInfoUpdateNotify Create()
		{
			return new TowerInfoUpdateNotify();
		}

		// Token: 0x17005D0E RID: 23822
		// (get) Token: 0x0601B7C2 RID: 112578 RVA: 0x003FEE51 File Offset: 0x003FD051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D0F RID: 23823
		// (get) Token: 0x0601B7C3 RID: 112579 RVA: 0x003FEE54 File Offset: 0x003FD054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601B7C4 RID: 112580 RVA: 0x003FEE5B File Offset: 0x003FD05B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerInfoUpdateNotify()
		{
		}

		// Token: 0x0601B7C5 RID: 112581 RVA: 0x003FEE63 File Offset: 0x003FD063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerInfoUpdateNotify(TowerInfoUpdateNotify other) : this()
		{
			this.towerInfo_ = ((other.towerInfo_ != null) ? other.towerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B7C6 RID: 112582 RVA: 0x003FEE98 File Offset: 0x003FD098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerInfoUpdateNotify Clone()
		{
			return new TowerInfoUpdateNotify(this);
		}

		// Token: 0x17005D10 RID: 23824
		// (get) Token: 0x0601B7C7 RID: 112583 RVA: 0x003FEEA0 File Offset: 0x003FD0A0
		// (set) Token: 0x0601B7C8 RID: 112584 RVA: 0x003FEEA8 File Offset: 0x003FD0A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerInfo TowerInfo
		{
			get
			{
				return this.towerInfo_;
			}
			set
			{
				this.towerInfo_ = value;
			}
		}

		// Token: 0x0601B7C9 RID: 112585 RVA: 0x003FEEB1 File Offset: 0x003FD0B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerInfoUpdateNotify);
		}

		// Token: 0x0601B7CA RID: 112586 RVA: 0x003FEEBF File Offset: 0x003FD0BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.TowerInfo, other.TowerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B7CB RID: 112587 RVA: 0x003FEEF4 File Offset: 0x003FD0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.towerInfo_ != null)
			{
				num ^= this.TowerInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B7CC RID: 112588 RVA: 0x003FEF30 File Offset: 0x003FD130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B7CD RID: 112589 RVA: 0x003FEF3D File Offset: 0x003FD13D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B7CE RID: 112590 RVA: 0x003FEF46 File Offset: 0x003FD146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.towerInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.TowerInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B7CF RID: 112591 RVA: 0x003FEF78 File Offset: 0x003FD178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.towerInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TowerInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B7D0 RID: 112592 RVA: 0x003FEFB8 File Offset: 0x003FD1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.towerInfo_ != null)
			{
				if (this.towerInfo_ == null)
				{
					this.TowerInfo = new TowerInfo();
				}
				this.TowerInfo.MergeFrom(other.TowerInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B7D1 RID: 112593 RVA: 0x003FF00C File Offset: 0x003FD20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B7D2 RID: 112594 RVA: 0x003FF018 File Offset: 0x003FD218
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.towerInfo_ == null)
					{
						this.TowerInfo = new TowerInfo();
					}
					input.ReadMessage(this.TowerInfo);
				}
			}
		}

		// Token: 0x04009FFA RID: 40954
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FFB RID: 40955
		public const int TowerInfoFieldNumber = 2;

		// Token: 0x04009FFC RID: 40956
		private TowerInfo towerInfo_;
	}
}

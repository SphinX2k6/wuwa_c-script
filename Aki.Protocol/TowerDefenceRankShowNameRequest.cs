using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200141E RID: 5150
	[NetMessage(EMessageId.TowerDefenceRankShowNameRequest)]
	public sealed class TowerDefenceRankShowNameRequest : IMessage<TowerDefenceRankShowNameRequest>, IMessage, IEquatable<TowerDefenceRankShowNameRequest>, IDeepCloneable<TowerDefenceRankShowNameRequest>, IBufferMessage
	{
		// Token: 0x0601B5FB RID: 112123 RVA: 0x003FB133 File Offset: 0x003F9333
		[NullableContext(1)]
		public static TowerDefenceRankShowNameRequest Create()
		{
			return new TowerDefenceRankShowNameRequest();
		}

		// Token: 0x17005CAC RID: 23724
		// (get) Token: 0x0601B5FC RID: 112124 RVA: 0x003FB13A File Offset: 0x003F933A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CAD RID: 23725
		// (get) Token: 0x0601B5FD RID: 112125 RVA: 0x003FB13D File Offset: 0x003F933D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceRankShowNameRequest.Descriptor;
			}
		}

		// Token: 0x0601B5FE RID: 112126 RVA: 0x003FB144 File Offset: 0x003F9344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRankShowNameRequest()
		{
		}

		// Token: 0x0601B5FF RID: 112127 RVA: 0x003FB14C File Offset: 0x003F934C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRankShowNameRequest(TowerDefenceRankShowNameRequest other) : this()
		{
			this.showName_ = other.showName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B600 RID: 112128 RVA: 0x003FB171 File Offset: 0x003F9371
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRankShowNameRequest Clone()
		{
			return new TowerDefenceRankShowNameRequest(this);
		}

		// Token: 0x17005CAE RID: 23726
		// (get) Token: 0x0601B601 RID: 112129 RVA: 0x003FB179 File Offset: 0x003F9379
		// (set) Token: 0x0601B602 RID: 112130 RVA: 0x003FB181 File Offset: 0x003F9381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ShowName
		{
			get
			{
				return this.showName_;
			}
			set
			{
				this.showName_ = value;
			}
		}

		// Token: 0x0601B603 RID: 112131 RVA: 0x003FB18A File Offset: 0x003F938A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceRankShowNameRequest);
		}

		// Token: 0x0601B604 RID: 112132 RVA: 0x003FB198 File Offset: 0x003F9398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceRankShowNameRequest other)
		{
			return other != null && (other == this || (this.ShowName == other.ShowName && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B605 RID: 112133 RVA: 0x003FB1C8 File Offset: 0x003F93C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShowName)
			{
				num ^= this.ShowName.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B606 RID: 112134 RVA: 0x003FB207 File Offset: 0x003F9407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B607 RID: 112135 RVA: 0x003FB214 File Offset: 0x003F9414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B608 RID: 112136 RVA: 0x003FB21D File Offset: 0x003F941D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShowName)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.ShowName);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B609 RID: 112137 RVA: 0x003FB250 File Offset: 0x003F9450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShowName)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B60A RID: 112138 RVA: 0x003FB282 File Offset: 0x003F9482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceRankShowNameRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShowName)
			{
				this.ShowName = other.ShowName;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B60B RID: 112139 RVA: 0x003FB2B3 File Offset: 0x003F94B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B60C RID: 112140 RVA: 0x003FB2BC File Offset: 0x003F94BC
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ShowName = input.ReadBool();
				}
			}
		}

		// Token: 0x04009F70 RID: 40816
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F71 RID: 40817
		public const int ShowNameFieldNumber = 12;

		// Token: 0x04009F72 RID: 40818
		private bool showName_;
	}
}

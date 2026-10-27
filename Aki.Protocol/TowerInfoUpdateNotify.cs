using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013C1 RID: 5057
	[NetMessage(EMessageId.TowerInfoUpdateNotify)]
	public sealed class TowerInfoUpdateNotify : IMessage<TowerInfoUpdateNotify>, IMessage, IEquatable<TowerInfoUpdateNotify>, IDeepCloneable<TowerInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601AD36 RID: 109878 RVA: 0x003E3B86 File Offset: 0x003E1D86
		[NullableContext(1)]
		public static TowerInfoUpdateNotify Create()
		{
			return new TowerInfoUpdateNotify();
		}

		// Token: 0x17005A79 RID: 23161
		// (get) Token: 0x0601AD37 RID: 109879 RVA: 0x003E3B8D File Offset: 0x003E1D8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A7A RID: 23162
		// (get) Token: 0x0601AD38 RID: 109880 RVA: 0x003E3B90 File Offset: 0x003E1D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601AD39 RID: 109881 RVA: 0x003E3B97 File Offset: 0x003E1D97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerInfoUpdateNotify()
		{
		}

		// Token: 0x0601AD3A RID: 109882 RVA: 0x003E3B9F File Offset: 0x003E1D9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerInfoUpdateNotify(TowerInfoUpdateNotify other) : this()
		{
			this.towerInfo_ = ((other.towerInfo_ != null) ? other.towerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AD3B RID: 109883 RVA: 0x003E3BD4 File Offset: 0x003E1DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerInfoUpdateNotify Clone()
		{
			return new TowerInfoUpdateNotify(this);
		}

		// Token: 0x17005A7B RID: 23163
		// (get) Token: 0x0601AD3C RID: 109884 RVA: 0x003E3BDC File Offset: 0x003E1DDC
		// (set) Token: 0x0601AD3D RID: 109885 RVA: 0x003E3BE4 File Offset: 0x003E1DE4
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

		// Token: 0x0601AD3E RID: 109886 RVA: 0x003E3BED File Offset: 0x003E1DED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerInfoUpdateNotify);
		}

		// Token: 0x0601AD3F RID: 109887 RVA: 0x003E3BFB File Offset: 0x003E1DFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.TowerInfo, other.TowerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AD40 RID: 109888 RVA: 0x003E3C30 File Offset: 0x003E1E30
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

		// Token: 0x0601AD41 RID: 109889 RVA: 0x003E3C6C File Offset: 0x003E1E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AD42 RID: 109890 RVA: 0x003E3C79 File Offset: 0x003E1E79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AD43 RID: 109891 RVA: 0x003E3C82 File Offset: 0x003E1E82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.towerInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.TowerInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AD44 RID: 109892 RVA: 0x003E3CB4 File Offset: 0x003E1EB4
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

		// Token: 0x0601AD45 RID: 109893 RVA: 0x003E3CF4 File Offset: 0x003E1EF4
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

		// Token: 0x0601AD46 RID: 109894 RVA: 0x003E3D48 File Offset: 0x003E1F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AD47 RID: 109895 RVA: 0x003E3D54 File Offset: 0x003E1F54
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
				if (num != 42U)
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

		// Token: 0x04009BB3 RID: 39859
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009BB4 RID: 39860
		public const int TowerInfoFieldNumber = 5;

		// Token: 0x04009BB5 RID: 39861
		private TowerInfo towerInfo_;
	}
}

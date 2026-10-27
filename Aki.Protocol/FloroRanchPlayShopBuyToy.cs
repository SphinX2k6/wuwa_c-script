using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005D1 RID: 1489
	public sealed class FloroRanchPlayShopBuyToy : IMessage<FloroRanchPlayShopBuyToy>, IMessage, IEquatable<FloroRanchPlayShopBuyToy>, IDeepCloneable<FloroRanchPlayShopBuyToy>, IBufferMessage
	{
		// Token: 0x060089AC RID: 35244 RVA: 0x0014C32A File Offset: 0x0014A52A
		[NullableContext(1)]
		public static FloroRanchPlayShopBuyToy Create()
		{
			return new FloroRanchPlayShopBuyToy();
		}

		// Token: 0x17001B12 RID: 6930
		// (get) Token: 0x060089AD RID: 35245 RVA: 0x0014C331 File Offset: 0x0014A531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B13 RID: 6931
		// (get) Token: 0x060089AE RID: 35246 RVA: 0x0014C334 File Offset: 0x0014A534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayShopBuyToy.Descriptor;
			}
		}

		// Token: 0x060089AF RID: 35247 RVA: 0x0014C33B File Offset: 0x0014A53B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyToy()
		{
		}

		// Token: 0x060089B0 RID: 35248 RVA: 0x0014C343 File Offset: 0x0014A543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyToy(FloroRanchPlayShopBuyToy other) : this()
		{
			this.newToy_ = ((other.newToy_ != null) ? other.newToy_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060089B1 RID: 35249 RVA: 0x0014C378 File Offset: 0x0014A578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyToy Clone()
		{
			return new FloroRanchPlayShopBuyToy(this);
		}

		// Token: 0x17001B14 RID: 6932
		// (get) Token: 0x060089B2 RID: 35250 RVA: 0x0014C380 File Offset: 0x0014A580
		// (set) Token: 0x060089B3 RID: 35251 RVA: 0x0014C388 File Offset: 0x0014A588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayUnit NewToy
		{
			get
			{
				return this.newToy_;
			}
			set
			{
				this.newToy_ = value;
			}
		}

		// Token: 0x060089B4 RID: 35252 RVA: 0x0014C391 File Offset: 0x0014A591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayShopBuyToy);
		}

		// Token: 0x060089B5 RID: 35253 RVA: 0x0014C39F File Offset: 0x0014A59F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayShopBuyToy other)
		{
			return other != null && (other == this || (object.Equals(this.NewToy, other.NewToy) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060089B6 RID: 35254 RVA: 0x0014C3D4 File Offset: 0x0014A5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.newToy_ != null)
			{
				num ^= this.NewToy.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060089B7 RID: 35255 RVA: 0x0014C410 File Offset: 0x0014A610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060089B8 RID: 35256 RVA: 0x0014C41D File Offset: 0x0014A61D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060089B9 RID: 35257 RVA: 0x0014C426 File Offset: 0x0014A626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.newToy_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.NewToy);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060089BA RID: 35258 RVA: 0x0014C458 File Offset: 0x0014A658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.newToy_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NewToy);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060089BB RID: 35259 RVA: 0x0014C498 File Offset: 0x0014A698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayShopBuyToy other)
		{
			if (other == null)
			{
				return;
			}
			if (other.newToy_ != null)
			{
				if (this.newToy_ == null)
				{
					this.NewToy = new FloroRanchPlayUnit();
				}
				this.NewToy.MergeFrom(other.NewToy);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060089BC RID: 35260 RVA: 0x0014C4EC File Offset: 0x0014A6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060089BD RID: 35261 RVA: 0x0014C4F8 File Offset: 0x0014A6F8
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.newToy_ == null)
					{
						this.NewToy = new FloroRanchPlayUnit();
					}
					input.ReadMessage(this.NewToy);
				}
			}
		}

		// Token: 0x040043AE RID: 17326
		private UnknownFieldSet _unknownFields;

		// Token: 0x040043AF RID: 17327
		public const int NewToyFieldNumber = 1;

		// Token: 0x040043B0 RID: 17328
		private FloroRanchPlayUnit newToy_;
	}
}

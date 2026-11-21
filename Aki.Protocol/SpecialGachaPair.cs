using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012D5 RID: 4821
	public sealed class SpecialGachaPair : IMessage<SpecialGachaPair>, IMessage, IEquatable<SpecialGachaPair>, IDeepCloneable<SpecialGachaPair>, IBufferMessage
	{
		// Token: 0x06019BB4 RID: 105396 RVA: 0x003C1132 File Offset: 0x003BF332
		[NullableContext(1)]
		public static SpecialGachaPair Create()
		{
			return new SpecialGachaPair();
		}

		// Token: 0x17005725 RID: 22309
		// (get) Token: 0x06019BB5 RID: 105397 RVA: 0x003C1139 File Offset: 0x003BF339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpecialGachaPair> Parser
		{
			get
			{
				return SpecialGachaPair._parser;
			}
		}

		// Token: 0x17005726 RID: 22310
		// (get) Token: 0x06019BB6 RID: 105398 RVA: 0x003C1140 File Offset: 0x003BF340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005727 RID: 22311
		// (get) Token: 0x06019BB7 RID: 105399 RVA: 0x003C1143 File Offset: 0x003BF343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpecialGachaPair.Descriptor;
			}
		}

		// Token: 0x06019BB8 RID: 105400 RVA: 0x003C114A File Offset: 0x003BF34A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialGachaPair()
		{
		}

		// Token: 0x06019BB9 RID: 105401 RVA: 0x003C1152 File Offset: 0x003BF352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialGachaPair(SpecialGachaPair other) : this()
		{
			this.typeId_ = other.typeId_;
			this.gachaId_ = other.gachaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019BBA RID: 105402 RVA: 0x003C1183 File Offset: 0x003BF383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialGachaPair Clone()
		{
			return new SpecialGachaPair(this);
		}

		// Token: 0x17005728 RID: 22312
		// (get) Token: 0x06019BBB RID: 105403 RVA: 0x003C118B File Offset: 0x003BF38B
		// (set) Token: 0x06019BBC RID: 105404 RVA: 0x003C1193 File Offset: 0x003BF393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TypeId
		{
			get
			{
				return this.typeId_;
			}
			set
			{
				this.typeId_ = value;
			}
		}

		// Token: 0x17005729 RID: 22313
		// (get) Token: 0x06019BBD RID: 105405 RVA: 0x003C119C File Offset: 0x003BF39C
		// (set) Token: 0x06019BBE RID: 105406 RVA: 0x003C11A4 File Offset: 0x003BF3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GachaId
		{
			get
			{
				return this.gachaId_;
			}
			set
			{
				this.gachaId_ = value;
			}
		}

		// Token: 0x06019BBF RID: 105407 RVA: 0x003C11AD File Offset: 0x003BF3AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpecialGachaPair);
		}

		// Token: 0x06019BC0 RID: 105408 RVA: 0x003C11BB File Offset: 0x003BF3BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpecialGachaPair other)
		{
			return other != null && (other == this || (this.TypeId == other.TypeId && this.GachaId == other.GachaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019BC1 RID: 105409 RVA: 0x003C11FC File Offset: 0x003BF3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TypeId != 0)
			{
				num ^= this.TypeId.GetHashCode();
			}
			if (this.GachaId != 0)
			{
				num ^= this.GachaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019BC2 RID: 105410 RVA: 0x003C1254 File Offset: 0x003BF454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019BC3 RID: 105411 RVA: 0x003C1261 File Offset: 0x003BF461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019BC4 RID: 105412 RVA: 0x003C126C File Offset: 0x003BF46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TypeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TypeId);
			}
			if (this.GachaId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.GachaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019BC5 RID: 105413 RVA: 0x003C12C4 File Offset: 0x003BF4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TypeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TypeId);
			}
			if (this.GachaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GachaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019BC6 RID: 105414 RVA: 0x003C131C File Offset: 0x003BF51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpecialGachaPair other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TypeId != 0)
			{
				this.TypeId = other.TypeId;
			}
			if (other.GachaId != 0)
			{
				this.GachaId = other.GachaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019BC7 RID: 105415 RVA: 0x003C136C File Offset: 0x003BF56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019BC8 RID: 105416 RVA: 0x003C1378 File Offset: 0x003BF578
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GachaId = input.ReadInt32();
					}
				}
				else
				{
					this.TypeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040097F3 RID: 38899
		private static readonly MessageParser<SpecialGachaPair> _parser = new MessageParser<SpecialGachaPair>(() => new SpecialGachaPair());

		// Token: 0x040097F4 RID: 38900
		private UnknownFieldSet _unknownFields;

		// Token: 0x040097F5 RID: 38901
		public const int TypeIdFieldNumber = 1;

		// Token: 0x040097F6 RID: 38902
		private int typeId_;

		// Token: 0x040097F7 RID: 38903
		public const int GachaIdFieldNumber = 2;

		// Token: 0x040097F8 RID: 38904
		private int gachaId_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001266 RID: 4710
	public sealed class SpecialGachaPair : IMessage<SpecialGachaPair>, IMessage, IEquatable<SpecialGachaPair>, IDeepCloneable<SpecialGachaPair>, IBufferMessage
	{
		// Token: 0x0601917E RID: 102782 RVA: 0x003A69EE File Offset: 0x003A4BEE
		[NullableContext(1)]
		public static SpecialGachaPair Create()
		{
			return new SpecialGachaPair();
		}

		// Token: 0x170054A4 RID: 21668
		// (get) Token: 0x0601917F RID: 102783 RVA: 0x003A69F5 File Offset: 0x003A4BF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpecialGachaPair> Parser
		{
			get
			{
				return SpecialGachaPair._parser;
			}
		}

		// Token: 0x170054A5 RID: 21669
		// (get) Token: 0x06019180 RID: 102784 RVA: 0x003A69FC File Offset: 0x003A4BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054A6 RID: 21670
		// (get) Token: 0x06019181 RID: 102785 RVA: 0x003A69FF File Offset: 0x003A4BFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpecialGachaPair.Descriptor;
			}
		}

		// Token: 0x06019182 RID: 102786 RVA: 0x003A6A06 File Offset: 0x003A4C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialGachaPair()
		{
		}

		// Token: 0x06019183 RID: 102787 RVA: 0x003A6A0E File Offset: 0x003A4C0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialGachaPair(SpecialGachaPair other) : this()
		{
			this.typeId_ = other.typeId_;
			this.gachaId_ = other.gachaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019184 RID: 102788 RVA: 0x003A6A3F File Offset: 0x003A4C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialGachaPair Clone()
		{
			return new SpecialGachaPair(this);
		}

		// Token: 0x170054A7 RID: 21671
		// (get) Token: 0x06019185 RID: 102789 RVA: 0x003A6A47 File Offset: 0x003A4C47
		// (set) Token: 0x06019186 RID: 102790 RVA: 0x003A6A4F File Offset: 0x003A4C4F
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

		// Token: 0x170054A8 RID: 21672
		// (get) Token: 0x06019187 RID: 102791 RVA: 0x003A6A58 File Offset: 0x003A4C58
		// (set) Token: 0x06019188 RID: 102792 RVA: 0x003A6A60 File Offset: 0x003A4C60
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

		// Token: 0x06019189 RID: 102793 RVA: 0x003A6A69 File Offset: 0x003A4C69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpecialGachaPair);
		}

		// Token: 0x0601918A RID: 102794 RVA: 0x003A6A77 File Offset: 0x003A4C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpecialGachaPair other)
		{
			return other != null && (other == this || (this.TypeId == other.TypeId && this.GachaId == other.GachaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601918B RID: 102795 RVA: 0x003A6AB8 File Offset: 0x003A4CB8
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

		// Token: 0x0601918C RID: 102796 RVA: 0x003A6B10 File Offset: 0x003A4D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601918D RID: 102797 RVA: 0x003A6B1D File Offset: 0x003A4D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601918E RID: 102798 RVA: 0x003A6B28 File Offset: 0x003A4D28
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

		// Token: 0x0601918F RID: 102799 RVA: 0x003A6B80 File Offset: 0x003A4D80
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

		// Token: 0x06019190 RID: 102800 RVA: 0x003A6BD8 File Offset: 0x003A4DD8
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

		// Token: 0x06019191 RID: 102801 RVA: 0x003A6C28 File Offset: 0x003A4E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019192 RID: 102802 RVA: 0x003A6C34 File Offset: 0x003A4E34
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

		// Token: 0x040093C9 RID: 37833
		private static readonly MessageParser<SpecialGachaPair> _parser = new MessageParser<SpecialGachaPair>(() => new SpecialGachaPair());

		// Token: 0x040093CA RID: 37834
		private UnknownFieldSet _unknownFields;

		// Token: 0x040093CB RID: 37835
		public const int TypeIdFieldNumber = 1;

		// Token: 0x040093CC RID: 37836
		private int typeId_;

		// Token: 0x040093CD RID: 37837
		public const int GachaIdFieldNumber = 2;

		// Token: 0x040093CE RID: 37838
		private int gachaId_;
	}
}

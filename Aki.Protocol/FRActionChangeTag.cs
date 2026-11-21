using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000629 RID: 1577
	public sealed class FRActionChangeTag : IMessage<FRActionChangeTag>, IMessage, IEquatable<FRActionChangeTag>, IDeepCloneable<FRActionChangeTag>, IBufferMessage
	{
		// Token: 0x060091CD RID: 37325 RVA: 0x0016167C File Offset: 0x0015F87C
		[NullableContext(1)]
		public static FRActionChangeTag Create()
		{
			return new FRActionChangeTag();
		}

		// Token: 0x17001D01 RID: 7425
		// (get) Token: 0x060091CE RID: 37326 RVA: 0x00161683 File Offset: 0x0015F883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D02 RID: 7426
		// (get) Token: 0x060091CF RID: 37327 RVA: 0x00161686 File Offset: 0x0015F886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRActionChangeTag.Descriptor;
			}
		}

		// Token: 0x060091D0 RID: 37328 RVA: 0x0016168D File Offset: 0x0015F88D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionChangeTag()
		{
		}

		// Token: 0x060091D1 RID: 37329 RVA: 0x00161695 File Offset: 0x0015F895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionChangeTag(FRActionChangeTag other) : this()
		{
			this.unitIncId_ = other.unitIncId_;
			this.tagId_ = other.tagId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060091D2 RID: 37330 RVA: 0x001616C6 File Offset: 0x0015F8C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionChangeTag Clone()
		{
			return new FRActionChangeTag(this);
		}

		// Token: 0x17001D03 RID: 7427
		// (get) Token: 0x060091D3 RID: 37331 RVA: 0x001616CE File Offset: 0x0015F8CE
		// (set) Token: 0x060091D4 RID: 37332 RVA: 0x001616D6 File Offset: 0x0015F8D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UnitIncId
		{
			get
			{
				return this.unitIncId_;
			}
			set
			{
				this.unitIncId_ = value;
			}
		}

		// Token: 0x17001D04 RID: 7428
		// (get) Token: 0x060091D5 RID: 37333 RVA: 0x001616DF File Offset: 0x0015F8DF
		// (set) Token: 0x060091D6 RID: 37334 RVA: 0x001616E7 File Offset: 0x0015F8E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TagId
		{
			get
			{
				return this.tagId_;
			}
			set
			{
				this.tagId_ = value;
			}
		}

		// Token: 0x060091D7 RID: 37335 RVA: 0x001616F0 File Offset: 0x0015F8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRActionChangeTag);
		}

		// Token: 0x060091D8 RID: 37336 RVA: 0x001616FE File Offset: 0x0015F8FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRActionChangeTag other)
		{
			return other != null && (other == this || (this.UnitIncId == other.UnitIncId && this.TagId == other.TagId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060091D9 RID: 37337 RVA: 0x0016173C File Offset: 0x0015F93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.UnitIncId != 0)
			{
				num ^= this.UnitIncId.GetHashCode();
			}
			if (this.TagId != 0L)
			{
				num ^= this.TagId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060091DA RID: 37338 RVA: 0x00161794 File Offset: 0x0015F994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060091DB RID: 37339 RVA: 0x001617A1 File Offset: 0x0015F9A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060091DC RID: 37340 RVA: 0x001617AC File Offset: 0x0015F9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.UnitIncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.UnitIncId);
			}
			if (this.TagId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.TagId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060091DD RID: 37341 RVA: 0x00161804 File Offset: 0x0015FA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.UnitIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UnitIncId);
			}
			if (this.TagId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TagId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060091DE RID: 37342 RVA: 0x0016185C File Offset: 0x0015FA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FRActionChangeTag other)
		{
			if (other == null)
			{
				return;
			}
			if (other.UnitIncId != 0)
			{
				this.UnitIncId = other.UnitIncId;
			}
			if (other.TagId != 0L)
			{
				this.TagId = other.TagId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060091DF RID: 37343 RVA: 0x001618AC File Offset: 0x0015FAAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060091E0 RID: 37344 RVA: 0x001618B8 File Offset: 0x0015FAB8
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
						this.TagId = input.ReadInt64();
					}
				}
				else
				{
					this.UnitIncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040046CC RID: 18124
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046CD RID: 18125
		public const int UnitIncIdFieldNumber = 1;

		// Token: 0x040046CE RID: 18126
		private int unitIncId_;

		// Token: 0x040046CF RID: 18127
		public const int TagIdFieldNumber = 2;

		// Token: 0x040046D0 RID: 18128
		private long tagId_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000641 RID: 1601
	public sealed class FRActionToyLvUp : IMessage<FRActionToyLvUp>, IMessage, IEquatable<FRActionToyLvUp>, IDeepCloneable<FRActionToyLvUp>, IBufferMessage
	{
		// Token: 0x06009373 RID: 37747 RVA: 0x00164B11 File Offset: 0x00162D11
		[NullableContext(1)]
		public static FRActionToyLvUp Create()
		{
			return new FRActionToyLvUp();
		}

		// Token: 0x17001D5B RID: 7515
		// (get) Token: 0x06009374 RID: 37748 RVA: 0x00164B18 File Offset: 0x00162D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D5C RID: 7516
		// (get) Token: 0x06009375 RID: 37749 RVA: 0x00164B1B File Offset: 0x00162D1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRActionToyLvUp.Descriptor;
			}
		}

		// Token: 0x06009376 RID: 37750 RVA: 0x00164B22 File Offset: 0x00162D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionToyLvUp()
		{
		}

		// Token: 0x06009377 RID: 37751 RVA: 0x00164B2A File Offset: 0x00162D2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionToyLvUp(FRActionToyLvUp other) : this()
		{
			this.toyId_ = other.toyId_;
			this.toyLv_ = other.toyLv_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009378 RID: 37752 RVA: 0x00164B5B File Offset: 0x00162D5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionToyLvUp Clone()
		{
			return new FRActionToyLvUp(this);
		}

		// Token: 0x17001D5D RID: 7517
		// (get) Token: 0x06009379 RID: 37753 RVA: 0x00164B63 File Offset: 0x00162D63
		// (set) Token: 0x0600937A RID: 37754 RVA: 0x00164B6B File Offset: 0x00162D6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ToyId
		{
			get
			{
				return this.toyId_;
			}
			set
			{
				this.toyId_ = value;
			}
		}

		// Token: 0x17001D5E RID: 7518
		// (get) Token: 0x0600937B RID: 37755 RVA: 0x00164B74 File Offset: 0x00162D74
		// (set) Token: 0x0600937C RID: 37756 RVA: 0x00164B7C File Offset: 0x00162D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ToyLv
		{
			get
			{
				return this.toyLv_;
			}
			set
			{
				this.toyLv_ = value;
			}
		}

		// Token: 0x0600937D RID: 37757 RVA: 0x00164B85 File Offset: 0x00162D85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRActionToyLvUp);
		}

		// Token: 0x0600937E RID: 37758 RVA: 0x00164B93 File Offset: 0x00162D93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRActionToyLvUp other)
		{
			return other != null && (other == this || (this.ToyId == other.ToyId && this.ToyLv == other.ToyLv && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600937F RID: 37759 RVA: 0x00164BD4 File Offset: 0x00162DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ToyId != 0)
			{
				num ^= this.ToyId.GetHashCode();
			}
			if (this.ToyLv != 0L)
			{
				num ^= this.ToyLv.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009380 RID: 37760 RVA: 0x00164C2C File Offset: 0x00162E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009381 RID: 37761 RVA: 0x00164C39 File Offset: 0x00162E39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009382 RID: 37762 RVA: 0x00164C44 File Offset: 0x00162E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ToyId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ToyId);
			}
			if (this.ToyLv != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.ToyLv);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009383 RID: 37763 RVA: 0x00164C9C File Offset: 0x00162E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ToyId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ToyId);
			}
			if (this.ToyLv != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ToyLv);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009384 RID: 37764 RVA: 0x00164CF4 File Offset: 0x00162EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FRActionToyLvUp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ToyId != 0)
			{
				this.ToyId = other.ToyId;
			}
			if (other.ToyLv != 0L)
			{
				this.ToyLv = other.ToyLv;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009385 RID: 37765 RVA: 0x00164D44 File Offset: 0x00162F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009386 RID: 37766 RVA: 0x00164D50 File Offset: 0x00162F50
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
						this.ToyLv = input.ReadInt64();
					}
				}
				else
				{
					this.ToyId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040046E7 RID: 18151
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046E8 RID: 18152
		public const int ToyIdFieldNumber = 1;

		// Token: 0x040046E9 RID: 18153
		private int toyId_;

		// Token: 0x040046EA RID: 18154
		public const int ToyLvFieldNumber = 2;

		// Token: 0x040046EB RID: 18155
		private long toyLv_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200062D RID: 1581
	public sealed class FRActionToyLvUp : IMessage<FRActionToyLvUp>, IMessage, IEquatable<FRActionToyLvUp>, IDeepCloneable<FRActionToyLvUp>, IBufferMessage
	{
		// Token: 0x0600921D RID: 37405 RVA: 0x001620E5 File Offset: 0x001602E5
		[NullableContext(1)]
		public static FRActionToyLvUp Create()
		{
			return new FRActionToyLvUp();
		}

		// Token: 0x17001D11 RID: 7441
		// (get) Token: 0x0600921E RID: 37406 RVA: 0x001620EC File Offset: 0x001602EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D12 RID: 7442
		// (get) Token: 0x0600921F RID: 37407 RVA: 0x001620EF File Offset: 0x001602EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRActionToyLvUp.Descriptor;
			}
		}

		// Token: 0x06009220 RID: 37408 RVA: 0x001620F6 File Offset: 0x001602F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionToyLvUp()
		{
		}

		// Token: 0x06009221 RID: 37409 RVA: 0x001620FE File Offset: 0x001602FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionToyLvUp(FRActionToyLvUp other) : this()
		{
			this.toyId_ = other.toyId_;
			this.toyLv_ = other.toyLv_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009222 RID: 37410 RVA: 0x0016212F File Offset: 0x0016032F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRActionToyLvUp Clone()
		{
			return new FRActionToyLvUp(this);
		}

		// Token: 0x17001D13 RID: 7443
		// (get) Token: 0x06009223 RID: 37411 RVA: 0x00162137 File Offset: 0x00160337
		// (set) Token: 0x06009224 RID: 37412 RVA: 0x0016213F File Offset: 0x0016033F
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

		// Token: 0x17001D14 RID: 7444
		// (get) Token: 0x06009225 RID: 37413 RVA: 0x00162148 File Offset: 0x00160348
		// (set) Token: 0x06009226 RID: 37414 RVA: 0x00162150 File Offset: 0x00160350
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

		// Token: 0x06009227 RID: 37415 RVA: 0x00162159 File Offset: 0x00160359
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRActionToyLvUp);
		}

		// Token: 0x06009228 RID: 37416 RVA: 0x00162167 File Offset: 0x00160367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRActionToyLvUp other)
		{
			return other != null && (other == this || (this.ToyId == other.ToyId && this.ToyLv == other.ToyLv && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009229 RID: 37417 RVA: 0x001621A8 File Offset: 0x001603A8
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

		// Token: 0x0600922A RID: 37418 RVA: 0x00162200 File Offset: 0x00160400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600922B RID: 37419 RVA: 0x0016220D File Offset: 0x0016040D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600922C RID: 37420 RVA: 0x00162218 File Offset: 0x00160418
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

		// Token: 0x0600922D RID: 37421 RVA: 0x00162270 File Offset: 0x00160470
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

		// Token: 0x0600922E RID: 37422 RVA: 0x001622C8 File Offset: 0x001604C8
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

		// Token: 0x0600922F RID: 37423 RVA: 0x00162318 File Offset: 0x00160518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009230 RID: 37424 RVA: 0x00162324 File Offset: 0x00160524
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

		// Token: 0x040046E0 RID: 18144
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046E1 RID: 18145
		public const int ToyIdFieldNumber = 1;

		// Token: 0x040046E2 RID: 18146
		private int toyId_;

		// Token: 0x040046E3 RID: 18147
		public const int ToyLvFieldNumber = 2;

		// Token: 0x040046E4 RID: 18148
		private long toyLv_;
	}
}

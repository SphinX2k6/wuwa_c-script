using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003EC RID: 1004
	public sealed class DrinkMixData : IMessage<DrinkMixData>, IMessage, IEquatable<DrinkMixData>, IDeepCloneable<DrinkMixData>, IBufferMessage
	{
		// Token: 0x06006193 RID: 24979 RVA: 0x000EB77C File Offset: 0x000E997C
		[NullableContext(1)]
		public static DrinkMixData Create()
		{
			return new DrinkMixData();
		}

		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x06006194 RID: 24980 RVA: 0x000EB783 File Offset: 0x000E9983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x06006195 RID: 24981 RVA: 0x000EB786 File Offset: 0x000E9986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DrinkMixData.Descriptor;
			}
		}

		// Token: 0x06006196 RID: 24982 RVA: 0x000EB78D File Offset: 0x000E998D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrinkMixData()
		{
		}

		// Token: 0x06006197 RID: 24983 RVA: 0x000EB7A0 File Offset: 0x000E99A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrinkMixData(DrinkMixData other) : this()
		{
			this.roleLevelInfo_ = other.roleLevelInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006198 RID: 24984 RVA: 0x000EB7CA File Offset: 0x000E99CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrinkMixData Clone()
		{
			return new DrinkMixData(this);
		}

		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x06006199 RID: 24985 RVA: 0x000EB7D2 File Offset: 0x000E99D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DrinkMixRole> RoleLevelInfo
		{
			get
			{
				return this.roleLevelInfo_;
			}
		}

		// Token: 0x0600619A RID: 24986 RVA: 0x000EB7DA File Offset: 0x000E99DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DrinkMixData);
		}

		// Token: 0x0600619B RID: 24987 RVA: 0x000EB7E8 File Offset: 0x000E99E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DrinkMixData other)
		{
			return other != null && (other == this || (this.roleLevelInfo_.Equals(other.roleLevelInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600619C RID: 24988 RVA: 0x000EB81C File Offset: 0x000E9A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roleLevelInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600619D RID: 24989 RVA: 0x000EB850 File Offset: 0x000E9A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600619E RID: 24990 RVA: 0x000EB85D File Offset: 0x000E9A5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600619F RID: 24991 RVA: 0x000EB866 File Offset: 0x000E9A66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleLevelInfo_.WriteTo(ref output, DrinkMixData._repeated_roleLevelInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060061A0 RID: 24992 RVA: 0x000EB890 File Offset: 0x000E9A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleLevelInfo_.CalculateSize(DrinkMixData._repeated_roleLevelInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060061A1 RID: 24993 RVA: 0x000EB8C9 File Offset: 0x000E9AC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DrinkMixData other)
		{
			if (other == null)
			{
				return;
			}
			this.roleLevelInfo_.Add(other.roleLevelInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060061A2 RID: 24994 RVA: 0x000EB8F7 File Offset: 0x000E9AF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060061A3 RID: 24995 RVA: 0x000EB900 File Offset: 0x000E9B00
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
					this.roleLevelInfo_.AddEntriesFrom(ref input, DrinkMixData._repeated_roleLevelInfo_codec);
				}
			}
		}

		// Token: 0x040037FA RID: 14330
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037FB RID: 14331
		public const int RoleLevelInfoFieldNumber = 1;

		// Token: 0x040037FC RID: 14332
		private static readonly FieldCodec<DrinkMixRole> _repeated_roleLevelInfo_codec = FieldCodec.ForMessage<DrinkMixRole>(10U, DrinkMixRole.Parser);

		// Token: 0x040037FD RID: 14333
		private readonly RepeatedField<DrinkMixRole> roleLevelInfo_ = new RepeatedField<DrinkMixRole>();
	}
}

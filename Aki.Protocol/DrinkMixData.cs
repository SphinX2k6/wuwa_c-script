using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000403 RID: 1027
	public sealed class DrinkMixData : IMessage<DrinkMixData>, IMessage, IEquatable<DrinkMixData>, IDeepCloneable<DrinkMixData>, IBufferMessage
	{
		// Token: 0x06006323 RID: 25379 RVA: 0x000EE8F4 File Offset: 0x000ECAF4
		[NullableContext(1)]
		public static DrinkMixData Create()
		{
			return new DrinkMixData();
		}

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x06006324 RID: 25380 RVA: 0x000EE8FB File Offset: 0x000ECAFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x06006325 RID: 25381 RVA: 0x000EE8FE File Offset: 0x000ECAFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DrinkMixData.Descriptor;
			}
		}

		// Token: 0x06006326 RID: 25382 RVA: 0x000EE905 File Offset: 0x000ECB05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrinkMixData()
		{
		}

		// Token: 0x06006327 RID: 25383 RVA: 0x000EE918 File Offset: 0x000ECB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrinkMixData(DrinkMixData other) : this()
		{
			this.roleLevelInfo_ = other.roleLevelInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006328 RID: 25384 RVA: 0x000EE942 File Offset: 0x000ECB42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrinkMixData Clone()
		{
			return new DrinkMixData(this);
		}

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x06006329 RID: 25385 RVA: 0x000EE94A File Offset: 0x000ECB4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DrinkMixRole> RoleLevelInfo
		{
			get
			{
				return this.roleLevelInfo_;
			}
		}

		// Token: 0x0600632A RID: 25386 RVA: 0x000EE952 File Offset: 0x000ECB52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DrinkMixData);
		}

		// Token: 0x0600632B RID: 25387 RVA: 0x000EE960 File Offset: 0x000ECB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DrinkMixData other)
		{
			return other != null && (other == this || (this.roleLevelInfo_.Equals(other.roleLevelInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600632C RID: 25388 RVA: 0x000EE994 File Offset: 0x000ECB94
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

		// Token: 0x0600632D RID: 25389 RVA: 0x000EE9C8 File Offset: 0x000ECBC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600632E RID: 25390 RVA: 0x000EE9D5 File Offset: 0x000ECBD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600632F RID: 25391 RVA: 0x000EE9DE File Offset: 0x000ECBDE
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

		// Token: 0x06006330 RID: 25392 RVA: 0x000EEA08 File Offset: 0x000ECC08
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

		// Token: 0x06006331 RID: 25393 RVA: 0x000EEA41 File Offset: 0x000ECC41
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

		// Token: 0x06006332 RID: 25394 RVA: 0x000EEA6F File Offset: 0x000ECC6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006333 RID: 25395 RVA: 0x000EEA78 File Offset: 0x000ECC78
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

		// Token: 0x0400380D RID: 14349
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400380E RID: 14350
		public const int RoleLevelInfoFieldNumber = 1;

		// Token: 0x0400380F RID: 14351
		private static readonly FieldCodec<DrinkMixRole> _repeated_roleLevelInfo_codec = FieldCodec.ForMessage<DrinkMixRole>(10U, DrinkMixRole.Parser);

		// Token: 0x04003810 RID: 14352
		private readonly RepeatedField<DrinkMixRole> roleLevelInfo_ = new RepeatedField<DrinkMixRole>();
	}
}

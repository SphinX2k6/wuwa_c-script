using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000434 RID: 1076
	[NetMessage(EMessageId.EnterAoiNotify)]
	public sealed class EnterAoiNotify : IMessage<EnterAoiNotify>, IMessage, IEquatable<EnterAoiNotify>, IDeepCloneable<EnterAoiNotify>, IBufferMessage
	{
		// Token: 0x06006779 RID: 26489 RVA: 0x000F8FD9 File Offset: 0x000F71D9
		[NullableContext(1)]
		public static EnterAoiNotify Create()
		{
			return new EnterAoiNotify();
		}

		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x0600677A RID: 26490 RVA: 0x000F8FE0 File Offset: 0x000F71E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x0600677B RID: 26491 RVA: 0x000F8FE3 File Offset: 0x000F71E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterAoiNotify.Descriptor;
			}
		}

		// Token: 0x0600677C RID: 26492 RVA: 0x000F8FEA File Offset: 0x000F71EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAoiNotify()
		{
		}

		// Token: 0x0600677D RID: 26493 RVA: 0x000F8FFD File Offset: 0x000F71FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAoiNotify(EnterAoiNotify other) : this()
		{
			this.entityInfos_ = other.entityInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600677E RID: 26494 RVA: 0x000F9027 File Offset: 0x000F7227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAoiNotify Clone()
		{
			return new EnterAoiNotify(this);
		}

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x0600677F RID: 26495 RVA: 0x000F902F File Offset: 0x000F722F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DynamicEntityInformation> EntityInfos
		{
			get
			{
				return this.entityInfos_;
			}
		}

		// Token: 0x06006780 RID: 26496 RVA: 0x000F9037 File Offset: 0x000F7237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterAoiNotify);
		}

		// Token: 0x06006781 RID: 26497 RVA: 0x000F9045 File Offset: 0x000F7245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterAoiNotify other)
		{
			return other != null && (other == this || (this.entityInfos_.Equals(other.entityInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006782 RID: 26498 RVA: 0x000F9078 File Offset: 0x000F7278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entityInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006783 RID: 26499 RVA: 0x000F90AC File Offset: 0x000F72AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006784 RID: 26500 RVA: 0x000F90B9 File Offset: 0x000F72B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006785 RID: 26501 RVA: 0x000F90C2 File Offset: 0x000F72C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityInfos_.WriteTo(ref output, EnterAoiNotify._repeated_entityInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006786 RID: 26502 RVA: 0x000F90EC File Offset: 0x000F72EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entityInfos_.CalculateSize(EnterAoiNotify._repeated_entityInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006787 RID: 26503 RVA: 0x000F9125 File Offset: 0x000F7325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterAoiNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.entityInfos_.Add(other.entityInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006788 RID: 26504 RVA: 0x000F9153 File Offset: 0x000F7353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006789 RID: 26505 RVA: 0x000F915C File Offset: 0x000F735C
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entityInfos_.AddEntriesFrom(ref input, EnterAoiNotify._repeated_entityInfos_codec);
				}
			}
		}

		// Token: 0x040039C9 RID: 14793
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039CA RID: 14794
		public const int EntityInfosFieldNumber = 3;

		// Token: 0x040039CB RID: 14795
		private static readonly FieldCodec<DynamicEntityInformation> _repeated_entityInfos_codec = FieldCodec.ForMessage<DynamicEntityInformation>(26U, DynamicEntityInformation.Parser);

		// Token: 0x040039CC RID: 14796
		private readonly RepeatedField<DynamicEntityInformation> entityInfos_ = new RepeatedField<DynamicEntityInformation>();
	}
}

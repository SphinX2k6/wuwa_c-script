using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BA0 RID: 2976
	[NetMessage(EMessageId.OrnamentDressInfoUpdateNotify)]
	public sealed class OrnamentDressInfoUpdateNotify : IMessage<OrnamentDressInfoUpdateNotify>, IMessage, IEquatable<OrnamentDressInfoUpdateNotify>, IDeepCloneable<OrnamentDressInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06010291 RID: 66193 RVA: 0x0025C751 File Offset: 0x0025A951
		[NullableContext(1)]
		public static OrnamentDressInfoUpdateNotify Create()
		{
			return new OrnamentDressInfoUpdateNotify();
		}

		// Token: 0x170034FE RID: 13566
		// (get) Token: 0x06010292 RID: 66194 RVA: 0x0025C758 File Offset: 0x0025A958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170034FF RID: 13567
		// (get) Token: 0x06010293 RID: 66195 RVA: 0x0025C75B File Offset: 0x0025A95B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OrnamentDressInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06010294 RID: 66196 RVA: 0x0025C762 File Offset: 0x0025A962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentDressInfoUpdateNotify()
		{
		}

		// Token: 0x06010295 RID: 66197 RVA: 0x0025C775 File Offset: 0x0025A975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentDressInfoUpdateNotify(OrnamentDressInfoUpdateNotify other) : this()
		{
			this.ornamentDressInfos_ = other.ornamentDressInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010296 RID: 66198 RVA: 0x0025C79F File Offset: 0x0025A99F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentDressInfoUpdateNotify Clone()
		{
			return new OrnamentDressInfoUpdateNotify(this);
		}

		// Token: 0x17003500 RID: 13568
		// (get) Token: 0x06010297 RID: 66199 RVA: 0x0025C7A7 File Offset: 0x0025A9A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OrnamentDressInfo> OrnamentDressInfos
		{
			get
			{
				return this.ornamentDressInfos_;
			}
		}

		// Token: 0x06010298 RID: 66200 RVA: 0x0025C7AF File Offset: 0x0025A9AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OrnamentDressInfoUpdateNotify);
		}

		// Token: 0x06010299 RID: 66201 RVA: 0x0025C7BD File Offset: 0x0025A9BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OrnamentDressInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.ornamentDressInfos_.Equals(other.ornamentDressInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601029A RID: 66202 RVA: 0x0025C7F0 File Offset: 0x0025A9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ornamentDressInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601029B RID: 66203 RVA: 0x0025C824 File Offset: 0x0025AA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601029C RID: 66204 RVA: 0x0025C831 File Offset: 0x0025AA31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601029D RID: 66205 RVA: 0x0025C83A File Offset: 0x0025AA3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ornamentDressInfos_.WriteTo(ref output, OrnamentDressInfoUpdateNotify._repeated_ornamentDressInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601029E RID: 66206 RVA: 0x0025C864 File Offset: 0x0025AA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ornamentDressInfos_.CalculateSize(OrnamentDressInfoUpdateNotify._repeated_ornamentDressInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601029F RID: 66207 RVA: 0x0025C89D File Offset: 0x0025AA9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OrnamentDressInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.ornamentDressInfos_.Add(other.ornamentDressInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060102A0 RID: 66208 RVA: 0x0025C8CB File Offset: 0x0025AACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060102A1 RID: 66209 RVA: 0x0025C8D4 File Offset: 0x0025AAD4
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ornamentDressInfos_.AddEntriesFrom(ref input, OrnamentDressInfoUpdateNotify._repeated_ornamentDressInfos_codec);
				}
			}
		}

		// Token: 0x0400675C RID: 26460
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400675D RID: 26461
		public const int OrnamentDressInfosFieldNumber = 4;

		// Token: 0x0400675E RID: 26462
		private static readonly FieldCodec<OrnamentDressInfo> _repeated_ornamentDressInfos_codec = FieldCodec.ForMessage<OrnamentDressInfo>(34U, OrnamentDressInfo.Parser);

		// Token: 0x0400675F RID: 26463
		private readonly RepeatedField<OrnamentDressInfo> ornamentDressInfos_ = new RepeatedField<OrnamentDressInfo>();
	}
}

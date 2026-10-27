using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B7D RID: 2941
	[NetMessage(EMessageId.OccupationInfoNotify)]
	public sealed class OccupationInfoNotify : IMessage<OccupationInfoNotify>, IMessage, IEquatable<OccupationInfoNotify>, IDeepCloneable<OccupationInfoNotify>, IBufferMessage
	{
		// Token: 0x0600FEE8 RID: 65256 RVA: 0x00252D4F File Offset: 0x00250F4F
		[NullableContext(1)]
		public static OccupationInfoNotify Create()
		{
			return new OccupationInfoNotify();
		}

		// Token: 0x1700340B RID: 13323
		// (get) Token: 0x0600FEE9 RID: 65257 RVA: 0x00252D56 File Offset: 0x00250F56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700340C RID: 13324
		// (get) Token: 0x0600FEEA RID: 65258 RVA: 0x00252D59 File Offset: 0x00250F59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OccupationInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600FEEB RID: 65259 RVA: 0x00252D60 File Offset: 0x00250F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupationInfoNotify()
		{
		}

		// Token: 0x0600FEEC RID: 65260 RVA: 0x00252D73 File Offset: 0x00250F73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupationInfoNotify(OccupationInfoNotify other) : this()
		{
			this.occupationInfo_ = other.occupationInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FEED RID: 65261 RVA: 0x00252D9D File Offset: 0x00250F9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupationInfoNotify Clone()
		{
			return new OccupationInfoNotify(this);
		}

		// Token: 0x1700340D RID: 13325
		// (get) Token: 0x0600FEEE RID: 65262 RVA: 0x00252DA5 File Offset: 0x00250FA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OccupationPbInfo> OccupationInfo
		{
			get
			{
				return this.occupationInfo_;
			}
		}

		// Token: 0x0600FEEF RID: 65263 RVA: 0x00252DAD File Offset: 0x00250FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OccupationInfoNotify);
		}

		// Token: 0x0600FEF0 RID: 65264 RVA: 0x00252DBB File Offset: 0x00250FBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OccupationInfoNotify other)
		{
			return other != null && (other == this || (this.occupationInfo_.Equals(other.occupationInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FEF1 RID: 65265 RVA: 0x00252DF0 File Offset: 0x00250FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.occupationInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FEF2 RID: 65266 RVA: 0x00252E24 File Offset: 0x00251024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FEF3 RID: 65267 RVA: 0x00252E31 File Offset: 0x00251031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FEF4 RID: 65268 RVA: 0x00252E3A File Offset: 0x0025103A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.occupationInfo_.WriteTo(ref output, OccupationInfoNotify._repeated_occupationInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FEF5 RID: 65269 RVA: 0x00252E64 File Offset: 0x00251064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.occupationInfo_.CalculateSize(OccupationInfoNotify._repeated_occupationInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FEF6 RID: 65270 RVA: 0x00252E9D File Offset: 0x0025109D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OccupationInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.occupationInfo_.Add(other.occupationInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FEF7 RID: 65271 RVA: 0x00252ECB File Offset: 0x002510CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FEF8 RID: 65272 RVA: 0x00252ED4 File Offset: 0x002510D4
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.occupationInfo_.AddEntriesFrom(ref input, OccupationInfoNotify._repeated_occupationInfo_codec);
				}
			}
		}

		// Token: 0x04006590 RID: 26000
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006591 RID: 26001
		public const int OccupationInfoFieldNumber = 7;

		// Token: 0x04006592 RID: 26002
		private static readonly FieldCodec<OccupationPbInfo> _repeated_occupationInfo_codec = FieldCodec.ForMessage<OccupationPbInfo>(58U, OccupationPbInfo.Parser);

		// Token: 0x04006593 RID: 26003
		private readonly RepeatedField<OccupationPbInfo> occupationInfo_ = new RepeatedField<OccupationPbInfo>();
	}
}

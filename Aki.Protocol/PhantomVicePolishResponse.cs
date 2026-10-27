using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D11 RID: 3345
	[NetMessage(EMessageId.PhantomVicePolishResponse)]
	public sealed class PhantomVicePolishResponse : IMessage<PhantomVicePolishResponse>, IMessage, IEquatable<PhantomVicePolishResponse>, IDeepCloneable<PhantomVicePolishResponse>, IBufferMessage
	{
		// Token: 0x0601212A RID: 74026 RVA: 0x002A4204 File Offset: 0x002A2404
		[NullableContext(1)]
		public static PhantomVicePolishResponse Create()
		{
			return new PhantomVicePolishResponse();
		}

		// Token: 0x17003BE1 RID: 15329
		// (get) Token: 0x0601212B RID: 74027 RVA: 0x002A420B File Offset: 0x002A240B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BE2 RID: 15330
		// (get) Token: 0x0601212C RID: 74028 RVA: 0x002A420E File Offset: 0x002A240E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomVicePolishResponse.Descriptor;
			}
		}

		// Token: 0x0601212D RID: 74029 RVA: 0x002A4215 File Offset: 0x002A2415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomVicePolishResponse()
		{
		}

		// Token: 0x0601212E RID: 74030 RVA: 0x002A4228 File Offset: 0x002A2428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomVicePolishResponse(PhantomVicePolishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomSubProp_ = other.phantomSubProp_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601212F RID: 74031 RVA: 0x002A425E File Offset: 0x002A245E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomVicePolishResponse Clone()
		{
			return new PhantomVicePolishResponse(this);
		}

		// Token: 0x17003BE3 RID: 15331
		// (get) Token: 0x06012130 RID: 74032 RVA: 0x002A4266 File Offset: 0x002A2466
		// (set) Token: 0x06012131 RID: 74033 RVA: 0x002A426E File Offset: 0x002A246E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17003BE4 RID: 15332
		// (get) Token: 0x06012132 RID: 74034 RVA: 0x002A4277 File Offset: 0x002A2477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomPropInfo> PhantomSubProp
		{
			get
			{
				return this.phantomSubProp_;
			}
		}

		// Token: 0x06012133 RID: 74035 RVA: 0x002A427F File Offset: 0x002A247F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomVicePolishResponse);
		}

		// Token: 0x06012134 RID: 74036 RVA: 0x002A4290 File Offset: 0x002A2490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomVicePolishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.phantomSubProp_.Equals(other.phantomSubProp_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012135 RID: 74037 RVA: 0x002A42E0 File Offset: 0x002A24E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.phantomSubProp_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012136 RID: 74038 RVA: 0x002A4333 File Offset: 0x002A2533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012137 RID: 74039 RVA: 0x002A4340 File Offset: 0x002A2540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012138 RID: 74040 RVA: 0x002A434C File Offset: 0x002A254C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomSubProp_.WriteTo(ref output, PhantomVicePolishResponse._repeated_phantomSubProp_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012139 RID: 74041 RVA: 0x002A439C File Offset: 0x002A259C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.phantomSubProp_.CalculateSize(PhantomVicePolishResponse._repeated_phantomSubProp_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601213A RID: 74042 RVA: 0x002A43F0 File Offset: 0x002A25F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomVicePolishResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.phantomSubProp_.Add(other.phantomSubProp_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601213B RID: 74043 RVA: 0x002A443D File Offset: 0x002A263D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601213C RID: 74044 RVA: 0x002A4448 File Offset: 0x002A2648
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
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.phantomSubProp_.AddEntriesFrom(ref input, PhantomVicePolishResponse._repeated_phantomSubProp_codec);
				}
			}
		}

		// Token: 0x04007114 RID: 28948
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007115 RID: 28949
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04007116 RID: 28950
		private ErrorCode errorCode_;

		// Token: 0x04007117 RID: 28951
		public const int PhantomSubPropFieldNumber = 7;

		// Token: 0x04007118 RID: 28952
		private static readonly FieldCodec<PhantomPropInfo> _repeated_phantomSubProp_codec = FieldCodec.ForMessage<PhantomPropInfo>(58U, PhantomPropInfo.Parser);

		// Token: 0x04007119 RID: 28953
		private readonly RepeatedField<PhantomPropInfo> phantomSubProp_ = new RepeatedField<PhantomPropInfo>();
	}
}

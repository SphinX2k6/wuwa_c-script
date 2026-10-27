using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005BF RID: 1471
	[NetMessage(EMessageId.FloroRanchPlayGachaResponse)]
	public sealed class FloroRanchPlayGachaResponse : IMessage<FloroRanchPlayGachaResponse>, IMessage, IEquatable<FloroRanchPlayGachaResponse>, IDeepCloneable<FloroRanchPlayGachaResponse>, IBufferMessage
	{
		// Token: 0x060087E3 RID: 34787 RVA: 0x00146FA1 File Offset: 0x001451A1
		[NullableContext(1)]
		public static FloroRanchPlayGachaResponse Create()
		{
			return new FloroRanchPlayGachaResponse();
		}

		// Token: 0x17001A98 RID: 6808
		// (get) Token: 0x060087E4 RID: 34788 RVA: 0x00146FA8 File Offset: 0x001451A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A99 RID: 6809
		// (get) Token: 0x060087E5 RID: 34789 RVA: 0x00146FAB File Offset: 0x001451AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayGachaResponse.Descriptor;
			}
		}

		// Token: 0x060087E6 RID: 34790 RVA: 0x00146FB2 File Offset: 0x001451B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGachaResponse()
		{
		}

		// Token: 0x060087E7 RID: 34791 RVA: 0x00146FC8 File Offset: 0x001451C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGachaResponse(FloroRanchPlayGachaResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.unit_ = ((other.unit_ != null) ? other.unit_.Clone() : null);
			this.gachaResult_ = other.gachaResult_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060087E8 RID: 34792 RVA: 0x00147025 File Offset: 0x00145225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGachaResponse Clone()
		{
			return new FloroRanchPlayGachaResponse(this);
		}

		// Token: 0x17001A9A RID: 6810
		// (get) Token: 0x060087E9 RID: 34793 RVA: 0x0014702D File Offset: 0x0014522D
		// (set) Token: 0x060087EA RID: 34794 RVA: 0x00147035 File Offset: 0x00145235
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

		// Token: 0x17001A9B RID: 6811
		// (get) Token: 0x060087EB RID: 34795 RVA: 0x0014703E File Offset: 0x0014523E
		// (set) Token: 0x060087EC RID: 34796 RVA: 0x00147046 File Offset: 0x00145246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayUnit Unit
		{
			get
			{
				return this.unit_;
			}
			set
			{
				this.unit_ = value;
			}
		}

		// Token: 0x17001A9C RID: 6812
		// (get) Token: 0x060087ED RID: 34797 RVA: 0x0014704F File Offset: 0x0014524F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayUnit> GachaResult
		{
			get
			{
				return this.gachaResult_;
			}
		}

		// Token: 0x060087EE RID: 34798 RVA: 0x00147057 File Offset: 0x00145257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayGachaResponse);
		}

		// Token: 0x060087EF RID: 34799 RVA: 0x00147068 File Offset: 0x00145268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayGachaResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Unit, other.Unit) && this.gachaResult_.Equals(other.gachaResult_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060087F0 RID: 34800 RVA: 0x001470CC File Offset: 0x001452CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.unit_ != null)
			{
				num ^= this.Unit.GetHashCode();
			}
			num ^= this.gachaResult_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060087F1 RID: 34801 RVA: 0x00147135 File Offset: 0x00145335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060087F2 RID: 34802 RVA: 0x00147142 File Offset: 0x00145342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060087F3 RID: 34803 RVA: 0x0014714C File Offset: 0x0014534C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gachaResult_.WriteTo(ref output, FloroRanchPlayGachaResponse._repeated_gachaResult_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.unit_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.Unit);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060087F4 RID: 34804 RVA: 0x001471B8 File Offset: 0x001453B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.unit_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Unit);
			}
			num += this.gachaResult_.CalculateSize(FloroRanchPlayGachaResponse._repeated_gachaResult_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060087F5 RID: 34805 RVA: 0x00147224 File Offset: 0x00145424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayGachaResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.unit_ != null)
			{
				if (this.unit_ == null)
				{
					this.Unit = new FloroRanchPlayUnit();
				}
				this.Unit.MergeFrom(other.Unit);
			}
			this.gachaResult_.Add(other.gachaResult_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060087F6 RID: 34806 RVA: 0x0014729D File Offset: 0x0014549D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060087F7 RID: 34807 RVA: 0x001472A8 File Offset: 0x001454A8
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
				if (num != 18U)
				{
					if (num != 56U)
					{
						if (num != 98U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.unit_ == null)
							{
								this.Unit = new FloroRanchPlayUnit();
							}
							input.ReadMessage(this.Unit);
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.gachaResult_.AddEntriesFrom(ref input, FloroRanchPlayGachaResponse._repeated_gachaResult_codec);
				}
			}
		}

		// Token: 0x040042E7 RID: 17127
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042E8 RID: 17128
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x040042E9 RID: 17129
		private ErrorCode errorCode_;

		// Token: 0x040042EA RID: 17130
		public const int UnitFieldNumber = 12;

		// Token: 0x040042EB RID: 17131
		private FloroRanchPlayUnit unit_;

		// Token: 0x040042EC RID: 17132
		public const int GachaResultFieldNumber = 2;

		// Token: 0x040042ED RID: 17133
		private static readonly FieldCodec<FloroRanchPlayUnit> _repeated_gachaResult_codec = FieldCodec.ForMessage<FloroRanchPlayUnit>(18U, FloroRanchPlayUnit.Parser);

		// Token: 0x040042EE RID: 17134
		private readonly RepeatedField<FloroRanchPlayUnit> gachaResult_ = new RepeatedField<FloroRanchPlayUnit>();
	}
}

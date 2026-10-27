using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000038 RID: 56
	[NetMessage(EMessageId.AbyssPluginSynthesisResponse)]
	public sealed class AbyssPluginSynthesisResponse : IMessage<AbyssPluginSynthesisResponse>, IMessage, IEquatable<AbyssPluginSynthesisResponse>, IDeepCloneable<AbyssPluginSynthesisResponse>, IBufferMessage
	{
		// Token: 0x060012F1 RID: 4849 RVA: 0x00033B89 File Offset: 0x00031D89
		[NullableContext(1)]
		public static AbyssPluginSynthesisResponse Create()
		{
			return new AbyssPluginSynthesisResponse();
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060012F2 RID: 4850 RVA: 0x00033B90 File Offset: 0x00031D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x00033B93 File Offset: 0x00031D93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssPluginSynthesisResponse.Descriptor;
			}
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x00033B9A File Offset: 0x00031D9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginSynthesisResponse()
		{
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x00033BAD File Offset: 0x00031DAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginSynthesisResponse(AbyssPluginSynthesisResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.outputItems_ = other.outputItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x00033BE3 File Offset: 0x00031DE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginSynthesisResponse Clone()
		{
			return new AbyssPluginSynthesisResponse(this);
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x00033BEB File Offset: 0x00031DEB
		// (set) Token: 0x060012F8 RID: 4856 RVA: 0x00033BF3 File Offset: 0x00031DF3
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

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060012F9 RID: 4857 RVA: 0x00033BFC File Offset: 0x00031DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AddCountItemInfo> OutputItems
		{
			get
			{
				return this.outputItems_;
			}
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x00033C04 File Offset: 0x00031E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssPluginSynthesisResponse);
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x00033C14 File Offset: 0x00031E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssPluginSynthesisResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.outputItems_.Equals(other.outputItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x00033C64 File Offset: 0x00031E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.outputItems_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x00033CB7 File Offset: 0x00031EB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x00033CC4 File Offset: 0x00031EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x00033CD0 File Offset: 0x00031ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.outputItems_.WriteTo(ref output, AbyssPluginSynthesisResponse._repeated_outputItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x00033D20 File Offset: 0x00031F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.outputItems_.CalculateSize(AbyssPluginSynthesisResponse._repeated_outputItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x00033D74 File Offset: 0x00031F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssPluginSynthesisResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.outputItems_.Add(other.outputItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x00033DC1 File Offset: 0x00031FC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x00033DCC File Offset: 0x00031FCC
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
				if (num != 32U)
				{
					if (num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.outputItems_.AddEntriesFrom(ref input, AbyssPluginSynthesisResponse._repeated_outputItems_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04001FED RID: 8173
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FEE RID: 8174
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04001FEF RID: 8175
		private ErrorCode errorCode_;

		// Token: 0x04001FF0 RID: 8176
		public const int OutputItemsFieldNumber = 6;

		// Token: 0x04001FF1 RID: 8177
		private static readonly FieldCodec<AddCountItemInfo> _repeated_outputItems_codec = FieldCodec.ForMessage<AddCountItemInfo>(50U, AddCountItemInfo.Parser);

		// Token: 0x04001FF2 RID: 8178
		private readonly RepeatedField<AddCountItemInfo> outputItems_ = new RepeatedField<AddCountItemInfo>();
	}
}

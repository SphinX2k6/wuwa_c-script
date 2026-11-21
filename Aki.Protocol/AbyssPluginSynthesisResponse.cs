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
		// Token: 0x0600131C RID: 4892 RVA: 0x0003413D File Offset: 0x0003233D
		[NullableContext(1)]
		public static AbyssPluginSynthesisResponse Create()
		{
			return new AbyssPluginSynthesisResponse();
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600131D RID: 4893 RVA: 0x00034144 File Offset: 0x00032344
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
		// (get) Token: 0x0600131E RID: 4894 RVA: 0x00034147 File Offset: 0x00032347
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssPluginSynthesisResponse.Descriptor;
			}
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x0003414E File Offset: 0x0003234E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginSynthesisResponse()
		{
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x00034161 File Offset: 0x00032361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginSynthesisResponse(AbyssPluginSynthesisResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.outputItems_ = other.outputItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x00034197 File Offset: 0x00032397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPluginSynthesisResponse Clone()
		{
			return new AbyssPluginSynthesisResponse(this);
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06001322 RID: 4898 RVA: 0x0003419F File Offset: 0x0003239F
		// (set) Token: 0x06001323 RID: 4899 RVA: 0x000341A7 File Offset: 0x000323A7
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
		// (get) Token: 0x06001324 RID: 4900 RVA: 0x000341B0 File Offset: 0x000323B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AddCountItemInfo> OutputItems
		{
			get
			{
				return this.outputItems_;
			}
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x000341B8 File Offset: 0x000323B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssPluginSynthesisResponse);
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x000341C8 File Offset: 0x000323C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssPluginSynthesisResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.outputItems_.Equals(other.outputItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x00034218 File Offset: 0x00032418
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

		// Token: 0x06001328 RID: 4904 RVA: 0x0003426B File Offset: 0x0003246B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x00034278 File Offset: 0x00032478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x00034284 File Offset: 0x00032484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.outputItems_.WriteTo(ref output, AbyssPluginSynthesisResponse._repeated_outputItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x000342D4 File Offset: 0x000324D4
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

		// Token: 0x0600132C RID: 4908 RVA: 0x00034328 File Offset: 0x00032528
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

		// Token: 0x0600132D RID: 4909 RVA: 0x00034375 File Offset: 0x00032575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x00034380 File Offset: 0x00032580
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
				if (num != 56U)
				{
					if (num != 106U)
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

		// Token: 0x04002043 RID: 8259
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002044 RID: 8260
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04002045 RID: 8261
		private ErrorCode errorCode_;

		// Token: 0x04002046 RID: 8262
		public const int OutputItemsFieldNumber = 13;

		// Token: 0x04002047 RID: 8263
		private static readonly FieldCodec<AddCountItemInfo> _repeated_outputItems_codec = FieldCodec.ForMessage<AddCountItemInfo>(106U, AddCountItemInfo.Parser);

		// Token: 0x04002048 RID: 8264
		private readonly RepeatedField<AddCountItemInfo> outputItems_ = new RepeatedField<AddCountItemInfo>();
	}
}

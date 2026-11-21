using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000867 RID: 2151
	[NetMessage(EMessageId.JokerGuessStartNewResponse)]
	public sealed class JokerGuessStartNewResponse : IMessage<JokerGuessStartNewResponse>, IMessage, IEquatable<JokerGuessStartNewResponse>, IDeepCloneable<JokerGuessStartNewResponse>, IBufferMessage
	{
		// Token: 0x0600BFF3 RID: 49139 RVA: 0x001C8764 File Offset: 0x001C6964
		[NullableContext(1)]
		public static JokerGuessStartNewResponse Create()
		{
			return new JokerGuessStartNewResponse();
		}

		// Token: 0x170026C5 RID: 9925
		// (get) Token: 0x0600BFF4 RID: 49140 RVA: 0x001C876B File Offset: 0x001C696B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026C6 RID: 9926
		// (get) Token: 0x0600BFF5 RID: 49141 RVA: 0x001C876E File Offset: 0x001C696E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessStartNewResponse.Descriptor;
			}
		}

		// Token: 0x0600BFF6 RID: 49142 RVA: 0x001C8775 File Offset: 0x001C6975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessStartNewResponse()
		{
		}

		// Token: 0x0600BFF7 RID: 49143 RVA: 0x001C8788 File Offset: 0x001C6988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessStartNewResponse(JokerGuessStartNewResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.initData_ = ((other.initData_ != null) ? other.initData_.Clone() : null);
			this.cmd_ = other.cmd_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BFF8 RID: 49144 RVA: 0x001C87E5 File Offset: 0x001C69E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessStartNewResponse Clone()
		{
			return new JokerGuessStartNewResponse(this);
		}

		// Token: 0x170026C7 RID: 9927
		// (get) Token: 0x0600BFF9 RID: 49145 RVA: 0x001C87ED File Offset: 0x001C69ED
		// (set) Token: 0x0600BFFA RID: 49146 RVA: 0x001C87F5 File Offset: 0x001C69F5
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

		// Token: 0x170026C8 RID: 9928
		// (get) Token: 0x0600BFFB RID: 49147 RVA: 0x001C87FE File Offset: 0x001C69FE
		// (set) Token: 0x0600BFFC RID: 49148 RVA: 0x001C8806 File Offset: 0x001C6A06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessInitGame InitData
		{
			get
			{
				return this.initData_;
			}
			set
			{
				this.initData_ = value;
			}
		}

		// Token: 0x170026C9 RID: 9929
		// (get) Token: 0x0600BFFD RID: 49149 RVA: 0x001C880F File Offset: 0x001C6A0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<JokerGuessOp> Cmd
		{
			get
			{
				return this.cmd_;
			}
		}

		// Token: 0x0600BFFE RID: 49150 RVA: 0x001C8817 File Offset: 0x001C6A17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessStartNewResponse);
		}

		// Token: 0x0600BFFF RID: 49151 RVA: 0x001C8828 File Offset: 0x001C6A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessStartNewResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.InitData, other.InitData) && this.cmd_.Equals(other.cmd_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C000 RID: 49152 RVA: 0x001C888C File Offset: 0x001C6A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.initData_ != null)
			{
				num ^= this.InitData.GetHashCode();
			}
			num ^= this.cmd_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C001 RID: 49153 RVA: 0x001C88F5 File Offset: 0x001C6AF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C002 RID: 49154 RVA: 0x001C8902 File Offset: 0x001C6B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C003 RID: 49155 RVA: 0x001C890C File Offset: 0x001C6B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.cmd_.WriteTo(ref output, JokerGuessStartNewResponse._repeated_cmd_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.initData_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.InitData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C004 RID: 49156 RVA: 0x001C8978 File Offset: 0x001C6B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.initData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InitData);
			}
			num += this.cmd_.CalculateSize(JokerGuessStartNewResponse._repeated_cmd_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C005 RID: 49157 RVA: 0x001C89E4 File Offset: 0x001C6BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JokerGuessStartNewResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.initData_ != null)
			{
				if (this.initData_ == null)
				{
					this.InitData = new JokerGuessInitGame();
				}
				this.InitData.MergeFrom(other.InitData);
			}
			this.cmd_.Add(other.cmd_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C006 RID: 49158 RVA: 0x001C8A5D File Offset: 0x001C6C5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C007 RID: 49159 RVA: 0x001C8A68 File Offset: 0x001C6C68
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
					if (num != 80U)
					{
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.initData_ == null)
							{
								this.InitData = new JokerGuessInitGame();
							}
							input.ReadMessage(this.InitData);
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.cmd_.AddEntriesFrom(ref input, JokerGuessStartNewResponse._repeated_cmd_codec);
				}
			}
		}

		// Token: 0x040053D0 RID: 21456
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053D1 RID: 21457
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040053D2 RID: 21458
		private ErrorCode errorCode_;

		// Token: 0x040053D3 RID: 21459
		public const int InitDataFieldNumber = 11;

		// Token: 0x040053D4 RID: 21460
		private JokerGuessInitGame initData_;

		// Token: 0x040053D5 RID: 21461
		public const int CmdFieldNumber = 3;

		// Token: 0x040053D6 RID: 21462
		private static readonly FieldCodec<JokerGuessOp> _repeated_cmd_codec = FieldCodec.ForMessage<JokerGuessOp>(26U, JokerGuessOp.Parser);

		// Token: 0x040053D7 RID: 21463
		private readonly RepeatedField<JokerGuessOp> cmd_ = new RepeatedField<JokerGuessOp>();
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001313 RID: 4883
	[NetMessage(EMessageId.SynthesisLevelRewardResponse)]
	public sealed class SynthesisLevelRewardResponse : IMessage<SynthesisLevelRewardResponse>, IMessage, IEquatable<SynthesisLevelRewardResponse>, IDeepCloneable<SynthesisLevelRewardResponse>, IBufferMessage
	{
		// Token: 0x06019F35 RID: 106293 RVA: 0x003C52C6 File Offset: 0x003C34C6
		[NullableContext(1)]
		public static SynthesisLevelRewardResponse Create()
		{
			return new SynthesisLevelRewardResponse();
		}

		// Token: 0x17005782 RID: 22402
		// (get) Token: 0x06019F36 RID: 106294 RVA: 0x003C52CD File Offset: 0x003C34CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005783 RID: 22403
		// (get) Token: 0x06019F37 RID: 106295 RVA: 0x003C52D0 File Offset: 0x003C34D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SynthesisLevelRewardResponse.Descriptor;
			}
		}

		// Token: 0x06019F38 RID: 106296 RVA: 0x003C52D7 File Offset: 0x003C34D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisLevelRewardResponse()
		{
		}

		// Token: 0x06019F39 RID: 106297 RVA: 0x003C52E0 File Offset: 0x003C34E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisLevelRewardResponse(SynthesisLevelRewardResponse other) : this()
		{
			this.code_ = other.code_;
			this.levelInfo_ = ((other.levelInfo_ != null) ? other.levelInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019F3A RID: 106298 RVA: 0x003C532C File Offset: 0x003C352C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisLevelRewardResponse Clone()
		{
			return new SynthesisLevelRewardResponse(this);
		}

		// Token: 0x17005784 RID: 22404
		// (get) Token: 0x06019F3B RID: 106299 RVA: 0x003C5334 File Offset: 0x003C3534
		// (set) Token: 0x06019F3C RID: 106300 RVA: 0x003C533C File Offset: 0x003C353C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17005785 RID: 22405
		// (get) Token: 0x06019F3D RID: 106301 RVA: 0x003C5345 File Offset: 0x003C3545
		// (set) Token: 0x06019F3E RID: 106302 RVA: 0x003C534D File Offset: 0x003C354D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisLevelInfo LevelInfo
		{
			get
			{
				return this.levelInfo_;
			}
			set
			{
				this.levelInfo_ = value;
			}
		}

		// Token: 0x06019F3F RID: 106303 RVA: 0x003C5356 File Offset: 0x003C3556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SynthesisLevelRewardResponse);
		}

		// Token: 0x06019F40 RID: 106304 RVA: 0x003C5364 File Offset: 0x003C3564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SynthesisLevelRewardResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this.LevelInfo, other.LevelInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019F41 RID: 106305 RVA: 0x003C53B4 File Offset: 0x003C35B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.levelInfo_ != null)
			{
				num ^= this.LevelInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019F42 RID: 106306 RVA: 0x003C540F File Offset: 0x003C360F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019F43 RID: 106307 RVA: 0x003C541C File Offset: 0x003C361C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019F44 RID: 106308 RVA: 0x003C5428 File Offset: 0x003C3628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.levelInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.LevelInfo);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019F45 RID: 106309 RVA: 0x003C5484 File Offset: 0x003C3684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.levelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LevelInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019F46 RID: 106310 RVA: 0x003C54DC File Offset: 0x003C36DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SynthesisLevelRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.levelInfo_ != null)
			{
				if (this.levelInfo_ == null)
				{
					this.LevelInfo = new SynthesisLevelInfo();
				}
				this.LevelInfo.MergeFrom(other.LevelInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019F47 RID: 106311 RVA: 0x003C5544 File Offset: 0x003C3744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019F48 RID: 106312 RVA: 0x003C5550 File Offset: 0x003C3750
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
				if (num != 42U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Code = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.levelInfo_ == null)
					{
						this.LevelInfo = new SynthesisLevelInfo();
					}
					input.ReadMessage(this.LevelInfo);
				}
			}
		}

		// Token: 0x040097A5 RID: 38821
		private UnknownFieldSet _unknownFields;

		// Token: 0x040097A6 RID: 38822
		public const int CodeFieldNumber = 15;

		// Token: 0x040097A7 RID: 38823
		private ErrorCode code_;

		// Token: 0x040097A8 RID: 38824
		public const int LevelInfoFieldNumber = 5;

		// Token: 0x040097A9 RID: 38825
		private SynthesisLevelInfo levelInfo_;
	}
}

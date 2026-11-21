using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001380 RID: 4992
	[NetMessage(EMessageId.SynthesisLevelRewardResponse)]
	public sealed class SynthesisLevelRewardResponse : IMessage<SynthesisLevelRewardResponse>, IMessage, IEquatable<SynthesisLevelRewardResponse>, IDeepCloneable<SynthesisLevelRewardResponse>, IBufferMessage
	{
		// Token: 0x0601A945 RID: 108869 RVA: 0x003DF582 File Offset: 0x003DD782
		[NullableContext(1)]
		public static SynthesisLevelRewardResponse Create()
		{
			return new SynthesisLevelRewardResponse();
		}

		// Token: 0x170059FC RID: 23036
		// (get) Token: 0x0601A946 RID: 108870 RVA: 0x003DF589 File Offset: 0x003DD789
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059FD RID: 23037
		// (get) Token: 0x0601A947 RID: 108871 RVA: 0x003DF58C File Offset: 0x003DD78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SynthesisLevelRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601A948 RID: 108872 RVA: 0x003DF593 File Offset: 0x003DD793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisLevelRewardResponse()
		{
		}

		// Token: 0x0601A949 RID: 108873 RVA: 0x003DF59C File Offset: 0x003DD79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisLevelRewardResponse(SynthesisLevelRewardResponse other) : this()
		{
			this.code_ = other.code_;
			this.levelInfo_ = ((other.levelInfo_ != null) ? other.levelInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A94A RID: 108874 RVA: 0x003DF5E8 File Offset: 0x003DD7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisLevelRewardResponse Clone()
		{
			return new SynthesisLevelRewardResponse(this);
		}

		// Token: 0x170059FE RID: 23038
		// (get) Token: 0x0601A94B RID: 108875 RVA: 0x003DF5F0 File Offset: 0x003DD7F0
		// (set) Token: 0x0601A94C RID: 108876 RVA: 0x003DF5F8 File Offset: 0x003DD7F8
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

		// Token: 0x170059FF RID: 23039
		// (get) Token: 0x0601A94D RID: 108877 RVA: 0x003DF601 File Offset: 0x003DD801
		// (set) Token: 0x0601A94E RID: 108878 RVA: 0x003DF609 File Offset: 0x003DD809
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

		// Token: 0x0601A94F RID: 108879 RVA: 0x003DF612 File Offset: 0x003DD812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SynthesisLevelRewardResponse);
		}

		// Token: 0x0601A950 RID: 108880 RVA: 0x003DF620 File Offset: 0x003DD820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SynthesisLevelRewardResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this.LevelInfo, other.LevelInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A951 RID: 108881 RVA: 0x003DF670 File Offset: 0x003DD870
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

		// Token: 0x0601A952 RID: 108882 RVA: 0x003DF6CB File Offset: 0x003DD8CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A953 RID: 108883 RVA: 0x003DF6D8 File Offset: 0x003DD8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A954 RID: 108884 RVA: 0x003DF6E4 File Offset: 0x003DD8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Code);
			}
			if (this.levelInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.LevelInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A955 RID: 108885 RVA: 0x003DF740 File Offset: 0x003DD940
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

		// Token: 0x0601A956 RID: 108886 RVA: 0x003DF798 File Offset: 0x003DD998
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

		// Token: 0x0601A957 RID: 108887 RVA: 0x003DF800 File Offset: 0x003DDA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A958 RID: 108888 RVA: 0x003DF80C File Offset: 0x003DDA0C
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
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009BC7 RID: 39879
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009BC8 RID: 39880
		public const int CodeFieldNumber = 4;

		// Token: 0x04009BC9 RID: 39881
		private ErrorCode code_;

		// Token: 0x04009BCA RID: 39882
		public const int LevelInfoFieldNumber = 10;

		// Token: 0x04009BCB RID: 39883
		private SynthesisLevelInfo levelInfo_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001381 RID: 4993
	[NetMessage(EMessageId.SynthesisLevelUpdateNotify)]
	public sealed class SynthesisLevelUpdateNotify : IMessage<SynthesisLevelUpdateNotify>, IMessage, IEquatable<SynthesisLevelUpdateNotify>, IDeepCloneable<SynthesisLevelUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601A959 RID: 108889 RVA: 0x003DF877 File Offset: 0x003DDA77
		[NullableContext(1)]
		public static SynthesisLevelUpdateNotify Create()
		{
			return new SynthesisLevelUpdateNotify();
		}

		// Token: 0x17005A00 RID: 23040
		// (get) Token: 0x0601A95A RID: 108890 RVA: 0x003DF87E File Offset: 0x003DDA7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A01 RID: 23041
		// (get) Token: 0x0601A95B RID: 108891 RVA: 0x003DF881 File Offset: 0x003DDA81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SynthesisLevelUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601A95C RID: 108892 RVA: 0x003DF888 File Offset: 0x003DDA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisLevelUpdateNotify()
		{
		}

		// Token: 0x0601A95D RID: 108893 RVA: 0x003DF890 File Offset: 0x003DDA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisLevelUpdateNotify(SynthesisLevelUpdateNotify other) : this()
		{
			this.levelInfo_ = ((other.levelInfo_ != null) ? other.levelInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A95E RID: 108894 RVA: 0x003DF8C5 File Offset: 0x003DDAC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisLevelUpdateNotify Clone()
		{
			return new SynthesisLevelUpdateNotify(this);
		}

		// Token: 0x17005A02 RID: 23042
		// (get) Token: 0x0601A95F RID: 108895 RVA: 0x003DF8CD File Offset: 0x003DDACD
		// (set) Token: 0x0601A960 RID: 108896 RVA: 0x003DF8D5 File Offset: 0x003DDAD5
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

		// Token: 0x0601A961 RID: 108897 RVA: 0x003DF8DE File Offset: 0x003DDADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SynthesisLevelUpdateNotify);
		}

		// Token: 0x0601A962 RID: 108898 RVA: 0x003DF8EC File Offset: 0x003DDAEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SynthesisLevelUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.LevelInfo, other.LevelInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A963 RID: 108899 RVA: 0x003DF920 File Offset: 0x003DDB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0601A964 RID: 108900 RVA: 0x003DF95C File Offset: 0x003DDB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A965 RID: 108901 RVA: 0x003DF969 File Offset: 0x003DDB69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A966 RID: 108902 RVA: 0x003DF972 File Offset: 0x003DDB72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.levelInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.LevelInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A967 RID: 108903 RVA: 0x003DF9A4 File Offset: 0x003DDBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0601A968 RID: 108904 RVA: 0x003DF9E4 File Offset: 0x003DDBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SynthesisLevelUpdateNotify other)
		{
			if (other == null)
			{
				return;
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

		// Token: 0x0601A969 RID: 108905 RVA: 0x003DFA38 File Offset: 0x003DDC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A96A RID: 108906 RVA: 0x003DFA44 File Offset: 0x003DDC44
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
				if (num != 122U)
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
		}

		// Token: 0x04009BCC RID: 39884
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009BCD RID: 39885
		public const int LevelInfoFieldNumber = 15;

		// Token: 0x04009BCE RID: 39886
		private SynthesisLevelInfo levelInfo_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001314 RID: 4884
	[NetMessage(EMessageId.SynthesisLevelUpdateNotify)]
	public sealed class SynthesisLevelUpdateNotify : IMessage<SynthesisLevelUpdateNotify>, IMessage, IEquatable<SynthesisLevelUpdateNotify>, IDeepCloneable<SynthesisLevelUpdateNotify>, IBufferMessage
	{
		// Token: 0x06019F49 RID: 106313 RVA: 0x003C55BB File Offset: 0x003C37BB
		[NullableContext(1)]
		public static SynthesisLevelUpdateNotify Create()
		{
			return new SynthesisLevelUpdateNotify();
		}

		// Token: 0x17005786 RID: 22406
		// (get) Token: 0x06019F4A RID: 106314 RVA: 0x003C55C2 File Offset: 0x003C37C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005787 RID: 22407
		// (get) Token: 0x06019F4B RID: 106315 RVA: 0x003C55C5 File Offset: 0x003C37C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SynthesisLevelUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06019F4C RID: 106316 RVA: 0x003C55CC File Offset: 0x003C37CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisLevelUpdateNotify()
		{
		}

		// Token: 0x06019F4D RID: 106317 RVA: 0x003C55D4 File Offset: 0x003C37D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisLevelUpdateNotify(SynthesisLevelUpdateNotify other) : this()
		{
			this.levelInfo_ = ((other.levelInfo_ != null) ? other.levelInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019F4E RID: 106318 RVA: 0x003C5609 File Offset: 0x003C3809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SynthesisLevelUpdateNotify Clone()
		{
			return new SynthesisLevelUpdateNotify(this);
		}

		// Token: 0x17005788 RID: 22408
		// (get) Token: 0x06019F4F RID: 106319 RVA: 0x003C5611 File Offset: 0x003C3811
		// (set) Token: 0x06019F50 RID: 106320 RVA: 0x003C5619 File Offset: 0x003C3819
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

		// Token: 0x06019F51 RID: 106321 RVA: 0x003C5622 File Offset: 0x003C3822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SynthesisLevelUpdateNotify);
		}

		// Token: 0x06019F52 RID: 106322 RVA: 0x003C5630 File Offset: 0x003C3830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SynthesisLevelUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.LevelInfo, other.LevelInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019F53 RID: 106323 RVA: 0x003C5664 File Offset: 0x003C3864
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

		// Token: 0x06019F54 RID: 106324 RVA: 0x003C56A0 File Offset: 0x003C38A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019F55 RID: 106325 RVA: 0x003C56AD File Offset: 0x003C38AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019F56 RID: 106326 RVA: 0x003C56B6 File Offset: 0x003C38B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.levelInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.LevelInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019F57 RID: 106327 RVA: 0x003C56E8 File Offset: 0x003C38E8
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

		// Token: 0x06019F58 RID: 106328 RVA: 0x003C5728 File Offset: 0x003C3928
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

		// Token: 0x06019F59 RID: 106329 RVA: 0x003C577C File Offset: 0x003C397C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019F5A RID: 106330 RVA: 0x003C5788 File Offset: 0x003C3988
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
				if (num != 74U)
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

		// Token: 0x040097AA RID: 38826
		private UnknownFieldSet _unknownFields;

		// Token: 0x040097AB RID: 38827
		public const int LevelInfoFieldNumber = 9;

		// Token: 0x040097AC RID: 38828
		private SynthesisLevelInfo levelInfo_;
	}
}

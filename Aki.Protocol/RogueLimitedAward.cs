using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FBE RID: 4030
	public sealed class RogueLimitedAward : IMessage<RogueLimitedAward>, IMessage, IEquatable<RogueLimitedAward>, IDeepCloneable<RogueLimitedAward>, IBufferMessage
	{
		// Token: 0x06015921 RID: 88353 RVA: 0x00322105 File Offset: 0x00320305
		[NullableContext(1)]
		public static RogueLimitedAward Create()
		{
			return new RogueLimitedAward();
		}

		// Token: 0x170047F3 RID: 18419
		// (get) Token: 0x06015922 RID: 88354 RVA: 0x0032210C File Offset: 0x0032030C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueLimitedAward> Parser
		{
			get
			{
				return RogueLimitedAward._parser;
			}
		}

		// Token: 0x170047F4 RID: 18420
		// (get) Token: 0x06015923 RID: 88355 RVA: 0x00322113 File Offset: 0x00320313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047F5 RID: 18421
		// (get) Token: 0x06015924 RID: 88356 RVA: 0x00322116 File Offset: 0x00320316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueLimitedAward.Descriptor;
			}
		}

		// Token: 0x06015925 RID: 88357 RVA: 0x0032211D File Offset: 0x0032031D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueLimitedAward()
		{
		}

		// Token: 0x06015926 RID: 88358 RVA: 0x00322128 File Offset: 0x00320328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueLimitedAward(RogueLimitedAward other) : this()
		{
			this.signState_ = other.signState_;
			this.curProgress_ = other.curProgress_;
			this.maxProgress_ = other.maxProgress_;
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015927 RID: 88359 RVA: 0x0032217C File Offset: 0x0032037C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueLimitedAward Clone()
		{
			return new RogueLimitedAward(this);
		}

		// Token: 0x170047F6 RID: 18422
		// (get) Token: 0x06015928 RID: 88360 RVA: 0x00322184 File Offset: 0x00320384
		// (set) Token: 0x06015929 RID: 88361 RVA: 0x0032218C File Offset: 0x0032038C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SignState SignState
		{
			get
			{
				return this.signState_;
			}
			set
			{
				this.signState_ = value;
			}
		}

		// Token: 0x170047F7 RID: 18423
		// (get) Token: 0x0601592A RID: 88362 RVA: 0x00322195 File Offset: 0x00320395
		// (set) Token: 0x0601592B RID: 88363 RVA: 0x0032219D File Offset: 0x0032039D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurProgress
		{
			get
			{
				return this.curProgress_;
			}
			set
			{
				this.curProgress_ = value;
			}
		}

		// Token: 0x170047F8 RID: 18424
		// (get) Token: 0x0601592C RID: 88364 RVA: 0x003221A6 File Offset: 0x003203A6
		// (set) Token: 0x0601592D RID: 88365 RVA: 0x003221AE File Offset: 0x003203AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxProgress
		{
			get
			{
				return this.maxProgress_;
			}
			set
			{
				this.maxProgress_ = value;
			}
		}

		// Token: 0x170047F9 RID: 18425
		// (get) Token: 0x0601592E RID: 88366 RVA: 0x003221B7 File Offset: 0x003203B7
		// (set) Token: 0x0601592F RID: 88367 RVA: 0x003221BF File Offset: 0x003203BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x06015930 RID: 88368 RVA: 0x003221C8 File Offset: 0x003203C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueLimitedAward);
		}

		// Token: 0x06015931 RID: 88369 RVA: 0x003221D8 File Offset: 0x003203D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueLimitedAward other)
		{
			return other != null && (other == this || (this.SignState == other.SignState && this.CurProgress == other.CurProgress && this.MaxProgress == other.MaxProgress && this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015932 RID: 88370 RVA: 0x00322244 File Offset: 0x00320444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SignState != SignState.Lock)
			{
				num ^= this.SignState.GetHashCode();
			}
			if (this.CurProgress != 0)
			{
				num ^= this.CurProgress.GetHashCode();
			}
			if (this.MaxProgress != 0)
			{
				num ^= this.MaxProgress.GetHashCode();
			}
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015933 RID: 88371 RVA: 0x003222D4 File Offset: 0x003204D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015934 RID: 88372 RVA: 0x003222E1 File Offset: 0x003204E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015935 RID: 88373 RVA: 0x003222EC File Offset: 0x003204EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SignState != SignState.Lock)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.SignState);
			}
			if (this.CurProgress != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurProgress);
			}
			if (this.MaxProgress != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.MaxProgress);
			}
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015936 RID: 88374 RVA: 0x0032237C File Offset: 0x0032057C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SignState != SignState.Lock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.SignState);
			}
			if (this.CurProgress != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurProgress);
			}
			if (this.MaxProgress != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxProgress);
			}
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015937 RID: 88375 RVA: 0x00322404 File Offset: 0x00320604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueLimitedAward other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SignState != SignState.Lock)
			{
				this.SignState = other.SignState;
			}
			if (other.CurProgress != 0)
			{
				this.CurProgress = other.CurProgress;
			}
			if (other.MaxProgress != 0)
			{
				this.MaxProgress = other.MaxProgress;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015938 RID: 88376 RVA: 0x0032247C File Offset: 0x0032067C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015939 RID: 88377 RVA: 0x00322488 File Offset: 0x00320688
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.SignState = (SignState)input.ReadEnum();
						continue;
					}
					if (num == 16U)
					{
						this.CurProgress = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.MaxProgress = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.ConfigId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008204 RID: 33284
		private static readonly MessageParser<RogueLimitedAward> _parser = new MessageParser<RogueLimitedAward>(() => new RogueLimitedAward());

		// Token: 0x04008205 RID: 33285
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008206 RID: 33286
		public const int SignStateFieldNumber = 1;

		// Token: 0x04008207 RID: 33287
		private SignState signState_;

		// Token: 0x04008208 RID: 33288
		public const int CurProgressFieldNumber = 2;

		// Token: 0x04008209 RID: 33289
		private int curProgress_;

		// Token: 0x0400820A RID: 33290
		public const int MaxProgressFieldNumber = 3;

		// Token: 0x0400820B RID: 33291
		private int maxProgress_;

		// Token: 0x0400820C RID: 33292
		public const int ConfigIdFieldNumber = 4;

		// Token: 0x0400820D RID: 33293
		private int configId_;
	}
}

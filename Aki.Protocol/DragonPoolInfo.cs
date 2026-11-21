using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003EA RID: 1002
	public sealed class DragonPoolInfo : IMessage<DragonPoolInfo>, IMessage, IEquatable<DragonPoolInfo>, IDeepCloneable<DragonPoolInfo>, IBufferMessage
	{
		// Token: 0x06006165 RID: 24933 RVA: 0x000EB0CB File Offset: 0x000E92CB
		[NullableContext(1)]
		public static DragonPoolInfo Create()
		{
			return new DragonPoolInfo();
		}

		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x06006166 RID: 24934 RVA: 0x000EB0D2 File Offset: 0x000E92D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DragonPoolInfo> Parser
		{
			get
			{
				return DragonPoolInfo._parser;
			}
		}

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x06006167 RID: 24935 RVA: 0x000EB0D9 File Offset: 0x000E92D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x06006168 RID: 24936 RVA: 0x000EB0DC File Offset: 0x000E92DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DragonPoolInfo.Descriptor;
			}
		}

		// Token: 0x06006169 RID: 24937 RVA: 0x000EB0E3 File Offset: 0x000E92E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DragonPoolInfo()
		{
		}

		// Token: 0x0600616A RID: 24938 RVA: 0x000EB0EC File Offset: 0x000E92EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DragonPoolInfo(DragonPoolInfo other) : this()
		{
			this.dragonPoolId_ = other.dragonPoolId_;
			this.level_ = other.level_;
			this.injectedCoreItemCount_ = other.injectedCoreItemCount_;
			this.levelGains_ = other.levelGains_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600616B RID: 24939 RVA: 0x000EB140 File Offset: 0x000E9340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DragonPoolInfo Clone()
		{
			return new DragonPoolInfo(this);
		}

		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x0600616C RID: 24940 RVA: 0x000EB148 File Offset: 0x000E9348
		// (set) Token: 0x0600616D RID: 24941 RVA: 0x000EB150 File Offset: 0x000E9350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DragonPoolId
		{
			get
			{
				return this.dragonPoolId_;
			}
			set
			{
				this.dragonPoolId_ = value;
			}
		}

		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x0600616E RID: 24942 RVA: 0x000EB159 File Offset: 0x000E9359
		// (set) Token: 0x0600616F RID: 24943 RVA: 0x000EB161 File Offset: 0x000E9361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x06006170 RID: 24944 RVA: 0x000EB16A File Offset: 0x000E936A
		// (set) Token: 0x06006171 RID: 24945 RVA: 0x000EB172 File Offset: 0x000E9372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InjectedCoreItemCount
		{
			get
			{
				return this.injectedCoreItemCount_;
			}
			set
			{
				this.injectedCoreItemCount_ = value;
			}
		}

		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x06006172 RID: 24946 RVA: 0x000EB17B File Offset: 0x000E937B
		// (set) Token: 0x06006173 RID: 24947 RVA: 0x000EB183 File Offset: 0x000E9383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelGains
		{
			get
			{
				return this.levelGains_;
			}
			set
			{
				this.levelGains_ = value;
			}
		}

		// Token: 0x06006174 RID: 24948 RVA: 0x000EB18C File Offset: 0x000E938C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DragonPoolInfo);
		}

		// Token: 0x06006175 RID: 24949 RVA: 0x000EB19C File Offset: 0x000E939C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DragonPoolInfo other)
		{
			return other != null && (other == this || (this.DragonPoolId == other.DragonPoolId && this.Level == other.Level && this.InjectedCoreItemCount == other.InjectedCoreItemCount && this.LevelGains == other.LevelGains && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006176 RID: 24950 RVA: 0x000EB208 File Offset: 0x000E9408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DragonPoolId != 0)
			{
				num ^= this.DragonPoolId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.InjectedCoreItemCount != 0)
			{
				num ^= this.InjectedCoreItemCount.GetHashCode();
			}
			if (this.LevelGains != 0)
			{
				num ^= this.LevelGains.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006177 RID: 24951 RVA: 0x000EB292 File Offset: 0x000E9492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006178 RID: 24952 RVA: 0x000EB29F File Offset: 0x000E949F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006179 RID: 24953 RVA: 0x000EB2A8 File Offset: 0x000E94A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DragonPoolId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DragonPoolId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Level);
			}
			if (this.InjectedCoreItemCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.InjectedCoreItemCount);
			}
			if (this.LevelGains != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.LevelGains);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600617A RID: 24954 RVA: 0x000EB338 File Offset: 0x000E9538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DragonPoolId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DragonPoolId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.InjectedCoreItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InjectedCoreItemCount);
			}
			if (this.LevelGains != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelGains);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600617B RID: 24955 RVA: 0x000EB3C0 File Offset: 0x000E95C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DragonPoolInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DragonPoolId != 0)
			{
				this.DragonPoolId = other.DragonPoolId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.InjectedCoreItemCount != 0)
			{
				this.InjectedCoreItemCount = other.InjectedCoreItemCount;
			}
			if (other.LevelGains != 0)
			{
				this.LevelGains = other.LevelGains;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600617C RID: 24956 RVA: 0x000EB438 File Offset: 0x000E9638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600617D RID: 24957 RVA: 0x000EB444 File Offset: 0x000E9644
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.DragonPoolId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.InjectedCoreItemCount = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.LevelGains = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040037EB RID: 14315
		private static readonly MessageParser<DragonPoolInfo> _parser = new MessageParser<DragonPoolInfo>(() => new DragonPoolInfo());

		// Token: 0x040037EC RID: 14316
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037ED RID: 14317
		public const int DragonPoolIdFieldNumber = 1;

		// Token: 0x040037EE RID: 14318
		private int dragonPoolId_;

		// Token: 0x040037EF RID: 14319
		public const int LevelFieldNumber = 3;

		// Token: 0x040037F0 RID: 14320
		private int level_;

		// Token: 0x040037F1 RID: 14321
		public const int InjectedCoreItemCountFieldNumber = 4;

		// Token: 0x040037F2 RID: 14322
		private int injectedCoreItemCount_;

		// Token: 0x040037F3 RID: 14323
		public const int LevelGainsFieldNumber = 5;

		// Token: 0x040037F4 RID: 14324
		private int levelGains_;
	}
}

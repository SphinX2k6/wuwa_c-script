using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000401 RID: 1025
	public sealed class DragonPoolInfo : IMessage<DragonPoolInfo>, IMessage, IEquatable<DragonPoolInfo>, IDeepCloneable<DragonPoolInfo>, IBufferMessage
	{
		// Token: 0x060062F5 RID: 25333 RVA: 0x000EE243 File Offset: 0x000EC443
		[NullableContext(1)]
		public static DragonPoolInfo Create()
		{
			return new DragonPoolInfo();
		}

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x060062F6 RID: 25334 RVA: 0x000EE24A File Offset: 0x000EC44A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DragonPoolInfo> Parser
		{
			get
			{
				return DragonPoolInfo._parser;
			}
		}

		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x060062F7 RID: 25335 RVA: 0x000EE251 File Offset: 0x000EC451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x060062F8 RID: 25336 RVA: 0x000EE254 File Offset: 0x000EC454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DragonPoolInfo.Descriptor;
			}
		}

		// Token: 0x060062F9 RID: 25337 RVA: 0x000EE25B File Offset: 0x000EC45B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DragonPoolInfo()
		{
		}

		// Token: 0x060062FA RID: 25338 RVA: 0x000EE264 File Offset: 0x000EC464
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

		// Token: 0x060062FB RID: 25339 RVA: 0x000EE2B8 File Offset: 0x000EC4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DragonPoolInfo Clone()
		{
			return new DragonPoolInfo(this);
		}

		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x060062FC RID: 25340 RVA: 0x000EE2C0 File Offset: 0x000EC4C0
		// (set) Token: 0x060062FD RID: 25341 RVA: 0x000EE2C8 File Offset: 0x000EC4C8
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

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x060062FE RID: 25342 RVA: 0x000EE2D1 File Offset: 0x000EC4D1
		// (set) Token: 0x060062FF RID: 25343 RVA: 0x000EE2D9 File Offset: 0x000EC4D9
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

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x06006300 RID: 25344 RVA: 0x000EE2E2 File Offset: 0x000EC4E2
		// (set) Token: 0x06006301 RID: 25345 RVA: 0x000EE2EA File Offset: 0x000EC4EA
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

		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x06006302 RID: 25346 RVA: 0x000EE2F3 File Offset: 0x000EC4F3
		// (set) Token: 0x06006303 RID: 25347 RVA: 0x000EE2FB File Offset: 0x000EC4FB
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

		// Token: 0x06006304 RID: 25348 RVA: 0x000EE304 File Offset: 0x000EC504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DragonPoolInfo);
		}

		// Token: 0x06006305 RID: 25349 RVA: 0x000EE314 File Offset: 0x000EC514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DragonPoolInfo other)
		{
			return other != null && (other == this || (this.DragonPoolId == other.DragonPoolId && this.Level == other.Level && this.InjectedCoreItemCount == other.InjectedCoreItemCount && this.LevelGains == other.LevelGains && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006306 RID: 25350 RVA: 0x000EE380 File Offset: 0x000EC580
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

		// Token: 0x06006307 RID: 25351 RVA: 0x000EE40A File Offset: 0x000EC60A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006308 RID: 25352 RVA: 0x000EE417 File Offset: 0x000EC617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006309 RID: 25353 RVA: 0x000EE420 File Offset: 0x000EC620
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

		// Token: 0x0600630A RID: 25354 RVA: 0x000EE4B0 File Offset: 0x000EC6B0
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

		// Token: 0x0600630B RID: 25355 RVA: 0x000EE538 File Offset: 0x000EC738
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

		// Token: 0x0600630C RID: 25356 RVA: 0x000EE5B0 File Offset: 0x000EC7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600630D RID: 25357 RVA: 0x000EE5BC File Offset: 0x000EC7BC
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

		// Token: 0x040037FE RID: 14334
		private static readonly MessageParser<DragonPoolInfo> _parser = new MessageParser<DragonPoolInfo>(() => new DragonPoolInfo());

		// Token: 0x040037FF RID: 14335
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003800 RID: 14336
		public const int DragonPoolIdFieldNumber = 1;

		// Token: 0x04003801 RID: 14337
		private int dragonPoolId_;

		// Token: 0x04003802 RID: 14338
		public const int LevelFieldNumber = 3;

		// Token: 0x04003803 RID: 14339
		private int level_;

		// Token: 0x04003804 RID: 14340
		public const int InjectedCoreItemCountFieldNumber = 4;

		// Token: 0x04003805 RID: 14341
		private int injectedCoreItemCount_;

		// Token: 0x04003806 RID: 14342
		public const int LevelGainsFieldNumber = 5;

		// Token: 0x04003807 RID: 14343
		private int levelGains_;
	}
}

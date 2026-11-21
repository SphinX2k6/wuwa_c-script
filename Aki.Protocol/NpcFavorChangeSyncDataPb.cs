using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B53 RID: 2899
	public sealed class NpcFavorChangeSyncDataPb : IMessage<NpcFavorChangeSyncDataPb>, IMessage, IEquatable<NpcFavorChangeSyncDataPb>, IDeepCloneable<NpcFavorChangeSyncDataPb>, IBufferMessage
	{
		// Token: 0x0600FB88 RID: 64392 RVA: 0x0024A654 File Offset: 0x00248854
		[NullableContext(1)]
		public static NpcFavorChangeSyncDataPb Create()
		{
			return new NpcFavorChangeSyncDataPb();
		}

		// Token: 0x17003340 RID: 13120
		// (get) Token: 0x0600FB89 RID: 64393 RVA: 0x0024A65B File Offset: 0x0024885B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003341 RID: 13121
		// (get) Token: 0x0600FB8A RID: 64394 RVA: 0x0024A65E File Offset: 0x0024885E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcFavorChangeSyncDataPb.Descriptor;
			}
		}

		// Token: 0x0600FB8B RID: 64395 RVA: 0x0024A665 File Offset: 0x00248865
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcFavorChangeSyncDataPb()
		{
		}

		// Token: 0x0600FB8C RID: 64396 RVA: 0x0024A66D File Offset: 0x0024886D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcFavorChangeSyncDataPb(NpcFavorChangeSyncDataPb other) : this()
		{
			this.npcId_ = other.npcId_;
			this.favorAbsolute_ = other.favorAbsolute_;
			this.favorLevel_ = other.favorLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FB8D RID: 64397 RVA: 0x0024A6AA File Offset: 0x002488AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcFavorChangeSyncDataPb Clone()
		{
			return new NpcFavorChangeSyncDataPb(this);
		}

		// Token: 0x17003342 RID: 13122
		// (get) Token: 0x0600FB8E RID: 64398 RVA: 0x0024A6B2 File Offset: 0x002488B2
		// (set) Token: 0x0600FB8F RID: 64399 RVA: 0x0024A6BA File Offset: 0x002488BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NpcId
		{
			get
			{
				return this.npcId_;
			}
			set
			{
				this.npcId_ = value;
			}
		}

		// Token: 0x17003343 RID: 13123
		// (get) Token: 0x0600FB90 RID: 64400 RVA: 0x0024A6C3 File Offset: 0x002488C3
		// (set) Token: 0x0600FB91 RID: 64401 RVA: 0x0024A6CB File Offset: 0x002488CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FavorAbsolute
		{
			get
			{
				return this.favorAbsolute_;
			}
			set
			{
				this.favorAbsolute_ = value;
			}
		}

		// Token: 0x17003344 RID: 13124
		// (get) Token: 0x0600FB92 RID: 64402 RVA: 0x0024A6D4 File Offset: 0x002488D4
		// (set) Token: 0x0600FB93 RID: 64403 RVA: 0x0024A6DC File Offset: 0x002488DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FavorLevel
		{
			get
			{
				return this.favorLevel_;
			}
			set
			{
				this.favorLevel_ = value;
			}
		}

		// Token: 0x0600FB94 RID: 64404 RVA: 0x0024A6E5 File Offset: 0x002488E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcFavorChangeSyncDataPb);
		}

		// Token: 0x0600FB95 RID: 64405 RVA: 0x0024A6F4 File Offset: 0x002488F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcFavorChangeSyncDataPb other)
		{
			return other != null && (other == this || (this.NpcId == other.NpcId && this.FavorAbsolute == other.FavorAbsolute && this.FavorLevel == other.FavorLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FB96 RID: 64406 RVA: 0x0024A750 File Offset: 0x00248950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NpcId != 0)
			{
				num ^= this.NpcId.GetHashCode();
			}
			if (this.FavorAbsolute != 0)
			{
				num ^= this.FavorAbsolute.GetHashCode();
			}
			if (this.FavorLevel != 0)
			{
				num ^= this.FavorLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FB97 RID: 64407 RVA: 0x0024A7C1 File Offset: 0x002489C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FB98 RID: 64408 RVA: 0x0024A7CE File Offset: 0x002489CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FB99 RID: 64409 RVA: 0x0024A7D8 File Offset: 0x002489D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NpcId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.NpcId);
			}
			if (this.FavorAbsolute != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.FavorAbsolute);
			}
			if (this.FavorLevel != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.FavorLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FB9A RID: 64410 RVA: 0x0024A84C File Offset: 0x00248A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NpcId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NpcId);
			}
			if (this.FavorAbsolute != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FavorAbsolute);
			}
			if (this.FavorLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FavorLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FB9B RID: 64411 RVA: 0x0024A8BC File Offset: 0x00248ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcFavorChangeSyncDataPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NpcId != 0)
			{
				this.NpcId = other.NpcId;
			}
			if (other.FavorAbsolute != 0)
			{
				this.FavorAbsolute = other.FavorAbsolute;
			}
			if (other.FavorLevel != 0)
			{
				this.FavorLevel = other.FavorLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FB9C RID: 64412 RVA: 0x0024A920 File Offset: 0x00248B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FB9D RID: 64413 RVA: 0x0024A92C File Offset: 0x00248B2C
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
				if (num != 8U)
				{
					if (num != 24U)
					{
						if (num != 32U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.FavorLevel = input.ReadInt32();
						}
					}
					else
					{
						this.FavorAbsolute = input.ReadInt32();
					}
				}
				else
				{
					this.NpcId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040064D8 RID: 25816
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064D9 RID: 25817
		public const int NpcIdFieldNumber = 1;

		// Token: 0x040064DA RID: 25818
		private int npcId_;

		// Token: 0x040064DB RID: 25819
		public const int FavorAbsoluteFieldNumber = 3;

		// Token: 0x040064DC RID: 25820
		private int favorAbsolute_;

		// Token: 0x040064DD RID: 25821
		public const int FavorLevelFieldNumber = 4;

		// Token: 0x040064DE RID: 25822
		private int favorLevel_;
	}
}

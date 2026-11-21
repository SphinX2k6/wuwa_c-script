using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001440 RID: 5184
	[NetMessage(EMessageId.TowerSeasonUpdateResponse)]
	public sealed class TowerSeasonUpdateResponse : IMessage<TowerSeasonUpdateResponse>, IMessage, IEquatable<TowerSeasonUpdateResponse>, IDeepCloneable<TowerSeasonUpdateResponse>, IBufferMessage
	{
		// Token: 0x0601B8B4 RID: 112820 RVA: 0x00400DBA File Offset: 0x003FEFBA
		[NullableContext(1)]
		public static TowerSeasonUpdateResponse Create()
		{
			return new TowerSeasonUpdateResponse();
		}

		// Token: 0x17005D40 RID: 23872
		// (get) Token: 0x0601B8B5 RID: 112821 RVA: 0x00400DC1 File Offset: 0x003FEFC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D41 RID: 23873
		// (get) Token: 0x0601B8B6 RID: 112822 RVA: 0x00400DC4 File Offset: 0x003FEFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerSeasonUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0601B8B7 RID: 112823 RVA: 0x00400DCB File Offset: 0x003FEFCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerSeasonUpdateResponse()
		{
		}

		// Token: 0x0601B8B8 RID: 112824 RVA: 0x00400DD4 File Offset: 0x003FEFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerSeasonUpdateResponse(TowerSeasonUpdateResponse other) : this()
		{
			this.towerInfo_ = ((other.towerInfo_ != null) ? other.towerInfo_.Clone() : null);
			this.maxUnlockDifficulty_ = other.maxUnlockDifficulty_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B8B9 RID: 112825 RVA: 0x00400E20 File Offset: 0x003FF020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerSeasonUpdateResponse Clone()
		{
			return new TowerSeasonUpdateResponse(this);
		}

		// Token: 0x17005D42 RID: 23874
		// (get) Token: 0x0601B8BA RID: 112826 RVA: 0x00400E28 File Offset: 0x003FF028
		// (set) Token: 0x0601B8BB RID: 112827 RVA: 0x00400E30 File Offset: 0x003FF030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerInfo TowerInfo
		{
			get
			{
				return this.towerInfo_;
			}
			set
			{
				this.towerInfo_ = value;
			}
		}

		// Token: 0x17005D43 RID: 23875
		// (get) Token: 0x0601B8BC RID: 112828 RVA: 0x00400E39 File Offset: 0x003FF039
		// (set) Token: 0x0601B8BD RID: 112829 RVA: 0x00400E41 File Offset: 0x003FF041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxUnlockDifficulty
		{
			get
			{
				return this.maxUnlockDifficulty_;
			}
			set
			{
				this.maxUnlockDifficulty_ = value;
			}
		}

		// Token: 0x0601B8BE RID: 112830 RVA: 0x00400E4A File Offset: 0x003FF04A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerSeasonUpdateResponse);
		}

		// Token: 0x0601B8BF RID: 112831 RVA: 0x00400E58 File Offset: 0x003FF058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerSeasonUpdateResponse other)
		{
			return other != null && (other == this || (object.Equals(this.TowerInfo, other.TowerInfo) && this.MaxUnlockDifficulty == other.MaxUnlockDifficulty && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B8C0 RID: 112832 RVA: 0x00400EA8 File Offset: 0x003FF0A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.towerInfo_ != null)
			{
				num ^= this.TowerInfo.GetHashCode();
			}
			if (this.MaxUnlockDifficulty != 0)
			{
				num ^= this.MaxUnlockDifficulty.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B8C1 RID: 112833 RVA: 0x00400EFD File Offset: 0x003FF0FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B8C2 RID: 112834 RVA: 0x00400F0A File Offset: 0x003FF10A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B8C3 RID: 112835 RVA: 0x00400F14 File Offset: 0x003FF114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.towerInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.TowerInfo);
			}
			if (this.MaxUnlockDifficulty != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.MaxUnlockDifficulty);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B8C4 RID: 112836 RVA: 0x00400F70 File Offset: 0x003FF170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.towerInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TowerInfo);
			}
			if (this.MaxUnlockDifficulty != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxUnlockDifficulty);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B8C5 RID: 112837 RVA: 0x00400FC8 File Offset: 0x003FF1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerSeasonUpdateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.towerInfo_ != null)
			{
				if (this.towerInfo_ == null)
				{
					this.TowerInfo = new TowerInfo();
				}
				this.TowerInfo.MergeFrom(other.TowerInfo);
			}
			if (other.MaxUnlockDifficulty != 0)
			{
				this.MaxUnlockDifficulty = other.MaxUnlockDifficulty;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B8C6 RID: 112838 RVA: 0x00401030 File Offset: 0x003FF230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B8C7 RID: 112839 RVA: 0x0040103C File Offset: 0x003FF23C
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
				if (num != 34U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MaxUnlockDifficulty = input.ReadInt32();
					}
				}
				else
				{
					if (this.towerInfo_ == null)
					{
						this.TowerInfo = new TowerInfo();
					}
					input.ReadMessage(this.TowerInfo);
				}
			}
		}

		// Token: 0x0400A03A RID: 41018
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A03B RID: 41019
		public const int TowerInfoFieldNumber = 4;

		// Token: 0x0400A03C RID: 41020
		private TowerInfo towerInfo_;

		// Token: 0x0400A03D RID: 41021
		public const int MaxUnlockDifficultyFieldNumber = 13;

		// Token: 0x0400A03E RID: 41022
		private int maxUnlockDifficulty_;
	}
}

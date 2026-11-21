using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200090F RID: 2319
	public sealed class LightBlockByLocationParam : IMessage<LightBlockByLocationParam>, IMessage, IEquatable<LightBlockByLocationParam>, IDeepCloneable<LightBlockByLocationParam>, IBufferMessage
	{
		// Token: 0x0600CCFE RID: 52478 RVA: 0x001E3AFD File Offset: 0x001E1CFD
		[NullableContext(1)]
		public static LightBlockByLocationParam Create()
		{
			return new LightBlockByLocationParam();
		}

		// Token: 0x17002963 RID: 10595
		// (get) Token: 0x0600CCFF RID: 52479 RVA: 0x001E3B04 File Offset: 0x001E1D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002964 RID: 10596
		// (get) Token: 0x0600CD00 RID: 52480 RVA: 0x001E3B07 File Offset: 0x001E1D07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LightBlockByLocationParam.Descriptor;
			}
		}

		// Token: 0x0600CD01 RID: 52481 RVA: 0x001E3B0E File Offset: 0x001E1D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LightBlockByLocationParam()
		{
		}

		// Token: 0x0600CD02 RID: 52482 RVA: 0x001E3B16 File Offset: 0x001E1D16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LightBlockByLocationParam(LightBlockByLocationParam other) : this()
		{
			this.gridIndex_ = other.gridIndex_;
			this.focusTime_ = other.focusTime_;
			this.backToPlayer_ = other.backToPlayer_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CD03 RID: 52483 RVA: 0x001E3B53 File Offset: 0x001E1D53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LightBlockByLocationParam Clone()
		{
			return new LightBlockByLocationParam(this);
		}

		// Token: 0x17002965 RID: 10597
		// (get) Token: 0x0600CD04 RID: 52484 RVA: 0x001E3B5B File Offset: 0x001E1D5B
		// (set) Token: 0x0600CD05 RID: 52485 RVA: 0x001E3B63 File Offset: 0x001E1D63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GridIndex
		{
			get
			{
				return this.gridIndex_;
			}
			set
			{
				this.gridIndex_ = value;
			}
		}

		// Token: 0x17002966 RID: 10598
		// (get) Token: 0x0600CD06 RID: 52486 RVA: 0x001E3B6C File Offset: 0x001E1D6C
		// (set) Token: 0x0600CD07 RID: 52487 RVA: 0x001E3B74 File Offset: 0x001E1D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FocusTime
		{
			get
			{
				return this.focusTime_;
			}
			set
			{
				this.focusTime_ = value;
			}
		}

		// Token: 0x17002967 RID: 10599
		// (get) Token: 0x0600CD08 RID: 52488 RVA: 0x001E3B7D File Offset: 0x001E1D7D
		// (set) Token: 0x0600CD09 RID: 52489 RVA: 0x001E3B85 File Offset: 0x001E1D85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool BackToPlayer
		{
			get
			{
				return this.backToPlayer_;
			}
			set
			{
				this.backToPlayer_ = value;
			}
		}

		// Token: 0x0600CD0A RID: 52490 RVA: 0x001E3B8E File Offset: 0x001E1D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LightBlockByLocationParam);
		}

		// Token: 0x0600CD0B RID: 52491 RVA: 0x001E3B9C File Offset: 0x001E1D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LightBlockByLocationParam other)
		{
			return other != null && (other == this || (this.GridIndex == other.GridIndex && this.FocusTime == other.FocusTime && this.BackToPlayer == other.BackToPlayer && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CD0C RID: 52492 RVA: 0x001E3BF8 File Offset: 0x001E1DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GridIndex != 0)
			{
				num ^= this.GridIndex.GetHashCode();
			}
			if (this.FocusTime != 0)
			{
				num ^= this.FocusTime.GetHashCode();
			}
			if (this.BackToPlayer)
			{
				num ^= this.BackToPlayer.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CD0D RID: 52493 RVA: 0x001E3C69 File Offset: 0x001E1E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CD0E RID: 52494 RVA: 0x001E3C76 File Offset: 0x001E1E76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CD0F RID: 52495 RVA: 0x001E3C80 File Offset: 0x001E1E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GridIndex != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GridIndex);
			}
			if (this.FocusTime != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.FocusTime);
			}
			if (this.BackToPlayer)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.BackToPlayer);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CD10 RID: 52496 RVA: 0x001E3CF4 File Offset: 0x001E1EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GridIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GridIndex);
			}
			if (this.FocusTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FocusTime);
			}
			if (this.BackToPlayer)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CD11 RID: 52497 RVA: 0x001E3D58 File Offset: 0x001E1F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LightBlockByLocationParam other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GridIndex != 0)
			{
				this.GridIndex = other.GridIndex;
			}
			if (other.FocusTime != 0)
			{
				this.FocusTime = other.FocusTime;
			}
			if (other.BackToPlayer)
			{
				this.BackToPlayer = other.BackToPlayer;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CD12 RID: 52498 RVA: 0x001E3DBC File Offset: 0x001E1FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CD13 RID: 52499 RVA: 0x001E3DC8 File Offset: 0x001E1FC8
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.BackToPlayer = input.ReadBool();
						}
					}
					else
					{
						this.FocusTime = input.ReadInt32();
					}
				}
				else
				{
					this.GridIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400572C RID: 22316
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400572D RID: 22317
		public const int GridIndexFieldNumber = 1;

		// Token: 0x0400572E RID: 22318
		private int gridIndex_;

		// Token: 0x0400572F RID: 22319
		public const int FocusTimeFieldNumber = 2;

		// Token: 0x04005730 RID: 22320
		private int focusTime_;

		// Token: 0x04005731 RID: 22321
		public const int BackToPlayerFieldNumber = 3;

		// Token: 0x04005732 RID: 22322
		private bool backToPlayer_;
	}
}

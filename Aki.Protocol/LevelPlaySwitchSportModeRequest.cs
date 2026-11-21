using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008FE RID: 2302
	[NetMessage(EMessageId.LevelPlaySwitchSportModeRequest)]
	public sealed class LevelPlaySwitchSportModeRequest : IMessage<LevelPlaySwitchSportModeRequest>, IMessage, IEquatable<LevelPlaySwitchSportModeRequest>, IDeepCloneable<LevelPlaySwitchSportModeRequest>, IBufferMessage
	{
		// Token: 0x0600CBA0 RID: 52128 RVA: 0x001E0ADA File Offset: 0x001DECDA
		[NullableContext(1)]
		public static LevelPlaySwitchSportModeRequest Create()
		{
			return new LevelPlaySwitchSportModeRequest();
		}

		// Token: 0x1700291A RID: 10522
		// (get) Token: 0x0600CBA1 RID: 52129 RVA: 0x001E0AE1 File Offset: 0x001DECE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700291B RID: 10523
		// (get) Token: 0x0600CBA2 RID: 52130 RVA: 0x001E0AE4 File Offset: 0x001DECE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlaySwitchSportModeRequest.Descriptor;
			}
		}

		// Token: 0x0600CBA3 RID: 52131 RVA: 0x001E0AEB File Offset: 0x001DECEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlaySwitchSportModeRequest()
		{
		}

		// Token: 0x0600CBA4 RID: 52132 RVA: 0x001E0AF3 File Offset: 0x001DECF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlaySwitchSportModeRequest(LevelPlaySwitchSportModeRequest other) : this()
		{
			this.oldSportMode_ = other.oldSportMode_;
			this.newSportMode_ = other.newSportMode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CBA5 RID: 52133 RVA: 0x001E0B24 File Offset: 0x001DED24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlaySwitchSportModeRequest Clone()
		{
			return new LevelPlaySwitchSportModeRequest(this);
		}

		// Token: 0x1700291C RID: 10524
		// (get) Token: 0x0600CBA6 RID: 52134 RVA: 0x001E0B2C File Offset: 0x001DED2C
		// (set) Token: 0x0600CBA7 RID: 52135 RVA: 0x001E0B34 File Offset: 0x001DED34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ELevelPlaySportMode OldSportMode
		{
			get
			{
				return this.oldSportMode_;
			}
			set
			{
				this.oldSportMode_ = value;
			}
		}

		// Token: 0x1700291D RID: 10525
		// (get) Token: 0x0600CBA8 RID: 52136 RVA: 0x001E0B3D File Offset: 0x001DED3D
		// (set) Token: 0x0600CBA9 RID: 52137 RVA: 0x001E0B45 File Offset: 0x001DED45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ELevelPlaySportMode NewSportMode
		{
			get
			{
				return this.newSportMode_;
			}
			set
			{
				this.newSportMode_ = value;
			}
		}

		// Token: 0x0600CBAA RID: 52138 RVA: 0x001E0B4E File Offset: 0x001DED4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlaySwitchSportModeRequest);
		}

		// Token: 0x0600CBAB RID: 52139 RVA: 0x001E0B5C File Offset: 0x001DED5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlaySwitchSportModeRequest other)
		{
			return other != null && (other == this || (this.OldSportMode == other.OldSportMode && this.NewSportMode == other.NewSportMode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CBAC RID: 52140 RVA: 0x001E0B9C File Offset: 0x001DED9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OldSportMode != ELevelPlaySportMode.None)
			{
				num ^= this.OldSportMode.GetHashCode();
			}
			if (this.NewSportMode != ELevelPlaySportMode.None)
			{
				num ^= this.NewSportMode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CBAD RID: 52141 RVA: 0x001E0C00 File Offset: 0x001DEE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CBAE RID: 52142 RVA: 0x001E0C0D File Offset: 0x001DEE0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CBAF RID: 52143 RVA: 0x001E0C18 File Offset: 0x001DEE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OldSportMode != ELevelPlaySportMode.None)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.OldSportMode);
			}
			if (this.NewSportMode != ELevelPlaySportMode.None)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.NewSportMode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CBB0 RID: 52144 RVA: 0x001E0C70 File Offset: 0x001DEE70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OldSportMode != ELevelPlaySportMode.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.OldSportMode);
			}
			if (this.NewSportMode != ELevelPlaySportMode.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.NewSportMode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CBB1 RID: 52145 RVA: 0x001E0CC8 File Offset: 0x001DEEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlaySwitchSportModeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OldSportMode != ELevelPlaySportMode.None)
			{
				this.OldSportMode = other.OldSportMode;
			}
			if (other.NewSportMode != ELevelPlaySportMode.None)
			{
				this.NewSportMode = other.NewSportMode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CBB2 RID: 52146 RVA: 0x001E0D18 File Offset: 0x001DEF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CBB3 RID: 52147 RVA: 0x001E0D24 File Offset: 0x001DEF24
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
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.NewSportMode = (ELevelPlaySportMode)input.ReadEnum();
					}
				}
				else
				{
					this.OldSportMode = (ELevelPlaySportMode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040056CD RID: 22221
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056CE RID: 22222
		public const int OldSportModeFieldNumber = 1;

		// Token: 0x040056CF RID: 22223
		private ELevelPlaySportMode oldSportMode_;

		// Token: 0x040056D0 RID: 22224
		public const int NewSportModeFieldNumber = 5;

		// Token: 0x040056D1 RID: 22225
		private ELevelPlaySportMode newSportMode_;
	}
}

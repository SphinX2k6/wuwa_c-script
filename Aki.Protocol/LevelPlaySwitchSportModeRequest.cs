using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200090F RID: 2319
	[NetMessage(EMessageId.LevelPlaySwitchSportModeRequest)]
	public sealed class LevelPlaySwitchSportModeRequest : IMessage<LevelPlaySwitchSportModeRequest>, IMessage, IEquatable<LevelPlaySwitchSportModeRequest>, IDeepCloneable<LevelPlaySwitchSportModeRequest>, IBufferMessage
	{
		// Token: 0x0600CCBC RID: 52412 RVA: 0x001E2DB2 File Offset: 0x001E0FB2
		[NullableContext(1)]
		public static LevelPlaySwitchSportModeRequest Create()
		{
			return new LevelPlaySwitchSportModeRequest();
		}

		// Token: 0x17002959 RID: 10585
		// (get) Token: 0x0600CCBD RID: 52413 RVA: 0x001E2DB9 File Offset: 0x001E0FB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700295A RID: 10586
		// (get) Token: 0x0600CCBE RID: 52414 RVA: 0x001E2DBC File Offset: 0x001E0FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlaySwitchSportModeRequest.Descriptor;
			}
		}

		// Token: 0x0600CCBF RID: 52415 RVA: 0x001E2DC3 File Offset: 0x001E0FC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlaySwitchSportModeRequest()
		{
		}

		// Token: 0x0600CCC0 RID: 52416 RVA: 0x001E2DCB File Offset: 0x001E0FCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlaySwitchSportModeRequest(LevelPlaySwitchSportModeRequest other) : this()
		{
			this.oldSportMode_ = other.oldSportMode_;
			this.newSportMode_ = other.newSportMode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CCC1 RID: 52417 RVA: 0x001E2DFC File Offset: 0x001E0FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlaySwitchSportModeRequest Clone()
		{
			return new LevelPlaySwitchSportModeRequest(this);
		}

		// Token: 0x1700295B RID: 10587
		// (get) Token: 0x0600CCC2 RID: 52418 RVA: 0x001E2E04 File Offset: 0x001E1004
		// (set) Token: 0x0600CCC3 RID: 52419 RVA: 0x001E2E0C File Offset: 0x001E100C
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

		// Token: 0x1700295C RID: 10588
		// (get) Token: 0x0600CCC4 RID: 52420 RVA: 0x001E2E15 File Offset: 0x001E1015
		// (set) Token: 0x0600CCC5 RID: 52421 RVA: 0x001E2E1D File Offset: 0x001E101D
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

		// Token: 0x0600CCC6 RID: 52422 RVA: 0x001E2E26 File Offset: 0x001E1026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlaySwitchSportModeRequest);
		}

		// Token: 0x0600CCC7 RID: 52423 RVA: 0x001E2E34 File Offset: 0x001E1034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlaySwitchSportModeRequest other)
		{
			return other != null && (other == this || (this.OldSportMode == other.OldSportMode && this.NewSportMode == other.NewSportMode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CCC8 RID: 52424 RVA: 0x001E2E74 File Offset: 0x001E1074
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

		// Token: 0x0600CCC9 RID: 52425 RVA: 0x001E2ED8 File Offset: 0x001E10D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CCCA RID: 52426 RVA: 0x001E2EE5 File Offset: 0x001E10E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CCCB RID: 52427 RVA: 0x001E2EF0 File Offset: 0x001E10F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NewSportMode != ELevelPlaySportMode.None)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.NewSportMode);
			}
			if (this.OldSportMode != ELevelPlaySportMode.None)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.OldSportMode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CCCC RID: 52428 RVA: 0x001E2F48 File Offset: 0x001E1148
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

		// Token: 0x0600CCCD RID: 52429 RVA: 0x001E2FA0 File Offset: 0x001E11A0
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

		// Token: 0x0600CCCE RID: 52430 RVA: 0x001E2FF0 File Offset: 0x001E11F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CCCF RID: 52431 RVA: 0x001E2FFC File Offset: 0x001E11FC
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.OldSportMode = (ELevelPlaySportMode)input.ReadEnum();
					}
				}
				else
				{
					this.NewSportMode = (ELevelPlaySportMode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040056C6 RID: 22214
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056C7 RID: 22215
		public const int OldSportModeFieldNumber = 15;

		// Token: 0x040056C8 RID: 22216
		private ELevelPlaySportMode oldSportMode_;

		// Token: 0x040056C9 RID: 22217
		public const int NewSportModeFieldNumber = 1;

		// Token: 0x040056CA RID: 22218
		private ELevelPlaySportMode newSportMode_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200144D RID: 5197
	public sealed class TrapDefenseSpawnMonsterStepPbData : IMessage<TrapDefenseSpawnMonsterStepPbData>, IMessage, IEquatable<TrapDefenseSpawnMonsterStepPbData>, IDeepCloneable<TrapDefenseSpawnMonsterStepPbData>, IBufferMessage
	{
		// Token: 0x0601B866 RID: 112742 RVA: 0x003FC1FD File Offset: 0x003FA3FD
		[NullableContext(1)]
		public static TrapDefenseSpawnMonsterStepPbData Create()
		{
			return new TrapDefenseSpawnMonsterStepPbData();
		}

		// Token: 0x17005CD1 RID: 23761
		// (get) Token: 0x0601B867 RID: 112743 RVA: 0x003FC204 File Offset: 0x003FA404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CD2 RID: 23762
		// (get) Token: 0x0601B868 RID: 112744 RVA: 0x003FC207 File Offset: 0x003FA407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseSpawnMonsterStepPbData.Descriptor;
			}
		}

		// Token: 0x0601B869 RID: 112745 RVA: 0x003FC20E File Offset: 0x003FA40E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpawnMonsterStepPbData()
		{
		}

		// Token: 0x0601B86A RID: 112746 RVA: 0x003FC216 File Offset: 0x003FA416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpawnMonsterStepPbData(TrapDefenseSpawnMonsterStepPbData other) : this()
		{
			this.endCountdownSecond_ = other.endCountdownSecond_;
			this.isWarningPrepareStyle_ = other.isWarningPrepareStyle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B86B RID: 112747 RVA: 0x003FC247 File Offset: 0x003FA447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpawnMonsterStepPbData Clone()
		{
			return new TrapDefenseSpawnMonsterStepPbData(this);
		}

		// Token: 0x17005CD3 RID: 23763
		// (get) Token: 0x0601B86C RID: 112748 RVA: 0x003FC24F File Offset: 0x003FA44F
		// (set) Token: 0x0601B86D RID: 112749 RVA: 0x003FC257 File Offset: 0x003FA457
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EndCountdownSecond
		{
			get
			{
				return this.endCountdownSecond_;
			}
			set
			{
				this.endCountdownSecond_ = value;
			}
		}

		// Token: 0x17005CD4 RID: 23764
		// (get) Token: 0x0601B86E RID: 112750 RVA: 0x003FC260 File Offset: 0x003FA460
		// (set) Token: 0x0601B86F RID: 112751 RVA: 0x003FC268 File Offset: 0x003FA468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsWarningPrepareStyle
		{
			get
			{
				return this.isWarningPrepareStyle_;
			}
			set
			{
				this.isWarningPrepareStyle_ = value;
			}
		}

		// Token: 0x0601B870 RID: 112752 RVA: 0x003FC271 File Offset: 0x003FA471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseSpawnMonsterStepPbData);
		}

		// Token: 0x0601B871 RID: 112753 RVA: 0x003FC27F File Offset: 0x003FA47F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseSpawnMonsterStepPbData other)
		{
			return other != null && (other == this || (this.EndCountdownSecond == other.EndCountdownSecond && this.IsWarningPrepareStyle == other.IsWarningPrepareStyle && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B872 RID: 112754 RVA: 0x003FC2C0 File Offset: 0x003FA4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EndCountdownSecond != 0)
			{
				num ^= this.EndCountdownSecond.GetHashCode();
			}
			if (this.IsWarningPrepareStyle)
			{
				num ^= this.IsWarningPrepareStyle.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B873 RID: 112755 RVA: 0x003FC318 File Offset: 0x003FA518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B874 RID: 112756 RVA: 0x003FC325 File Offset: 0x003FA525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B875 RID: 112757 RVA: 0x003FC330 File Offset: 0x003FA530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EndCountdownSecond != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EndCountdownSecond);
			}
			if (this.IsWarningPrepareStyle)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsWarningPrepareStyle);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B876 RID: 112758 RVA: 0x003FC388 File Offset: 0x003FA588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EndCountdownSecond != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EndCountdownSecond);
			}
			if (this.IsWarningPrepareStyle)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B877 RID: 112759 RVA: 0x003FC3D4 File Offset: 0x003FA5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseSpawnMonsterStepPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EndCountdownSecond != 0)
			{
				this.EndCountdownSecond = other.EndCountdownSecond;
			}
			if (other.IsWarningPrepareStyle)
			{
				this.IsWarningPrepareStyle = other.IsWarningPrepareStyle;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B878 RID: 112760 RVA: 0x003FC424 File Offset: 0x003FA624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B879 RID: 112761 RVA: 0x003FC430 File Offset: 0x003FA630
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsWarningPrepareStyle = input.ReadBool();
					}
				}
				else
				{
					this.EndCountdownSecond = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009EBD RID: 40637
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009EBE RID: 40638
		public const int EndCountdownSecondFieldNumber = 1;

		// Token: 0x04009EBF RID: 40639
		private int endCountdownSecond_;

		// Token: 0x04009EC0 RID: 40640
		public const int IsWarningPrepareStyleFieldNumber = 2;

		// Token: 0x04009EC1 RID: 40641
		private bool isWarningPrepareStyle_;
	}
}

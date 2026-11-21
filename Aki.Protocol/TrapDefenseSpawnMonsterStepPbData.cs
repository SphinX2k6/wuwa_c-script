using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014C0 RID: 5312
	public sealed class TrapDefenseSpawnMonsterStepPbData : IMessage<TrapDefenseSpawnMonsterStepPbData>, IMessage, IEquatable<TrapDefenseSpawnMonsterStepPbData>, IDeepCloneable<TrapDefenseSpawnMonsterStepPbData>, IBufferMessage
	{
		// Token: 0x0601C2F1 RID: 115441 RVA: 0x004174D1 File Offset: 0x004156D1
		[NullableContext(1)]
		public static TrapDefenseSpawnMonsterStepPbData Create()
		{
			return new TrapDefenseSpawnMonsterStepPbData();
		}

		// Token: 0x17005F66 RID: 24422
		// (get) Token: 0x0601C2F2 RID: 115442 RVA: 0x004174D8 File Offset: 0x004156D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F67 RID: 24423
		// (get) Token: 0x0601C2F3 RID: 115443 RVA: 0x004174DB File Offset: 0x004156DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseSpawnMonsterStepPbData.Descriptor;
			}
		}

		// Token: 0x0601C2F4 RID: 115444 RVA: 0x004174E2 File Offset: 0x004156E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpawnMonsterStepPbData()
		{
		}

		// Token: 0x0601C2F5 RID: 115445 RVA: 0x004174EA File Offset: 0x004156EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpawnMonsterStepPbData(TrapDefenseSpawnMonsterStepPbData other) : this()
		{
			this.endCountdownSecond_ = other.endCountdownSecond_;
			this.isWarningPrepareStyle_ = other.isWarningPrepareStyle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C2F6 RID: 115446 RVA: 0x0041751B File Offset: 0x0041571B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpawnMonsterStepPbData Clone()
		{
			return new TrapDefenseSpawnMonsterStepPbData(this);
		}

		// Token: 0x17005F68 RID: 24424
		// (get) Token: 0x0601C2F7 RID: 115447 RVA: 0x00417523 File Offset: 0x00415723
		// (set) Token: 0x0601C2F8 RID: 115448 RVA: 0x0041752B File Offset: 0x0041572B
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

		// Token: 0x17005F69 RID: 24425
		// (get) Token: 0x0601C2F9 RID: 115449 RVA: 0x00417534 File Offset: 0x00415734
		// (set) Token: 0x0601C2FA RID: 115450 RVA: 0x0041753C File Offset: 0x0041573C
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

		// Token: 0x0601C2FB RID: 115451 RVA: 0x00417545 File Offset: 0x00415745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseSpawnMonsterStepPbData);
		}

		// Token: 0x0601C2FC RID: 115452 RVA: 0x00417553 File Offset: 0x00415753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseSpawnMonsterStepPbData other)
		{
			return other != null && (other == this || (this.EndCountdownSecond == other.EndCountdownSecond && this.IsWarningPrepareStyle == other.IsWarningPrepareStyle && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C2FD RID: 115453 RVA: 0x00417594 File Offset: 0x00415794
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

		// Token: 0x0601C2FE RID: 115454 RVA: 0x004175EC File Offset: 0x004157EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C2FF RID: 115455 RVA: 0x004175F9 File Offset: 0x004157F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C300 RID: 115456 RVA: 0x00417604 File Offset: 0x00415804
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

		// Token: 0x0601C301 RID: 115457 RVA: 0x0041765C File Offset: 0x0041585C
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

		// Token: 0x0601C302 RID: 115458 RVA: 0x004176A8 File Offset: 0x004158A8
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

		// Token: 0x0601C303 RID: 115459 RVA: 0x004176F8 File Offset: 0x004158F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C304 RID: 115460 RVA: 0x00417704 File Offset: 0x00415904
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

		// Token: 0x0400A304 RID: 41732
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A305 RID: 41733
		public const int EndCountdownSecondFieldNumber = 1;

		// Token: 0x0400A306 RID: 41734
		private int endCountdownSecond_;

		// Token: 0x0400A307 RID: 41735
		public const int IsWarningPrepareStyleFieldNumber = 2;

		// Token: 0x0400A308 RID: 41736
		private bool isWarningPrepareStyle_;
	}
}

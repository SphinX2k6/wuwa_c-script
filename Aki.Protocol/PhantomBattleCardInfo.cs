using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C51 RID: 3153
	public sealed class PhantomBattleCardInfo : IMessage<PhantomBattleCardInfo>, IMessage, IEquatable<PhantomBattleCardInfo>, IDeepCloneable<PhantomBattleCardInfo>, IBufferMessage
	{
		// Token: 0x06011194 RID: 70036 RVA: 0x0028122F File Offset: 0x0027F42F
		[NullableContext(1)]
		public static PhantomBattleCardInfo Create()
		{
			return new PhantomBattleCardInfo();
		}

		// Token: 0x17003886 RID: 14470
		// (get) Token: 0x06011195 RID: 70037 RVA: 0x00281236 File Offset: 0x0027F436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleCardInfo> Parser
		{
			get
			{
				return PhantomBattleCardInfo._parser;
			}
		}

		// Token: 0x17003887 RID: 14471
		// (get) Token: 0x06011196 RID: 70038 RVA: 0x0028123D File Offset: 0x0027F43D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003888 RID: 14472
		// (get) Token: 0x06011197 RID: 70039 RVA: 0x00281240 File Offset: 0x0027F440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardInfo.Descriptor;
			}
		}

		// Token: 0x06011198 RID: 70040 RVA: 0x00281247 File Offset: 0x0027F447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardInfo()
		{
		}

		// Token: 0x06011199 RID: 70041 RVA: 0x0028124F File Offset: 0x0027F44F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardInfo(PhantomBattleCardInfo other) : this()
		{
			this.phantomBattleCardId_ = other.phantomBattleCardId_;
			this.isUnlock_ = other.isUnlock_;
			this.isUnlockOutLook_ = other.isUnlockOutLook_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601119A RID: 70042 RVA: 0x0028128C File Offset: 0x0027F48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardInfo Clone()
		{
			return new PhantomBattleCardInfo(this);
		}

		// Token: 0x17003889 RID: 14473
		// (get) Token: 0x0601119B RID: 70043 RVA: 0x00281294 File Offset: 0x0027F494
		// (set) Token: 0x0601119C RID: 70044 RVA: 0x0028129C File Offset: 0x0027F49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomBattleCardId
		{
			get
			{
				return this.phantomBattleCardId_;
			}
			set
			{
				this.phantomBattleCardId_ = value;
			}
		}

		// Token: 0x1700388A RID: 14474
		// (get) Token: 0x0601119D RID: 70045 RVA: 0x002812A5 File Offset: 0x0027F4A5
		// (set) Token: 0x0601119E RID: 70046 RVA: 0x002812AD File Offset: 0x0027F4AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlock
		{
			get
			{
				return this.isUnlock_;
			}
			set
			{
				this.isUnlock_ = value;
			}
		}

		// Token: 0x1700388B RID: 14475
		// (get) Token: 0x0601119F RID: 70047 RVA: 0x002812B6 File Offset: 0x0027F4B6
		// (set) Token: 0x060111A0 RID: 70048 RVA: 0x002812BE File Offset: 0x0027F4BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlockOutLook
		{
			get
			{
				return this.isUnlockOutLook_;
			}
			set
			{
				this.isUnlockOutLook_ = value;
			}
		}

		// Token: 0x060111A1 RID: 70049 RVA: 0x002812C7 File Offset: 0x0027F4C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardInfo);
		}

		// Token: 0x060111A2 RID: 70050 RVA: 0x002812D8 File Offset: 0x0027F4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardInfo other)
		{
			return other != null && (other == this || (this.PhantomBattleCardId == other.PhantomBattleCardId && this.IsUnlock == other.IsUnlock && this.IsUnlockOutLook == other.IsUnlockOutLook && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060111A3 RID: 70051 RVA: 0x00281334 File Offset: 0x0027F534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PhantomBattleCardId != 0)
			{
				num ^= this.PhantomBattleCardId.GetHashCode();
			}
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			if (this.IsUnlockOutLook)
			{
				num ^= this.IsUnlockOutLook.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060111A4 RID: 70052 RVA: 0x002813A5 File Offset: 0x0027F5A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060111A5 RID: 70053 RVA: 0x002813B2 File Offset: 0x0027F5B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060111A6 RID: 70054 RVA: 0x002813BC File Offset: 0x0027F5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PhantomBattleCardId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PhantomBattleCardId);
			}
			if (this.IsUnlock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsUnlock);
			}
			if (this.IsUnlockOutLook)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsUnlockOutLook);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060111A7 RID: 70055 RVA: 0x00281430 File Offset: 0x0027F630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PhantomBattleCardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomBattleCardId);
			}
			if (this.IsUnlock)
			{
				num += 2;
			}
			if (this.IsUnlockOutLook)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060111A8 RID: 70056 RVA: 0x00281488 File Offset: 0x0027F688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PhantomBattleCardId != 0)
			{
				this.PhantomBattleCardId = other.PhantomBattleCardId;
			}
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			if (other.IsUnlockOutLook)
			{
				this.IsUnlockOutLook = other.IsUnlockOutLook;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060111A9 RID: 70057 RVA: 0x002814EC File Offset: 0x0027F6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060111AA RID: 70058 RVA: 0x002814F8 File Offset: 0x0027F6F8
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
							this.IsUnlockOutLook = input.ReadBool();
						}
					}
					else
					{
						this.IsUnlock = input.ReadBool();
					}
				}
				else
				{
					this.PhantomBattleCardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006C53 RID: 27731
		private static readonly MessageParser<PhantomBattleCardInfo> _parser = new MessageParser<PhantomBattleCardInfo>(() => new PhantomBattleCardInfo());

		// Token: 0x04006C54 RID: 27732
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C55 RID: 27733
		public const int PhantomBattleCardIdFieldNumber = 1;

		// Token: 0x04006C56 RID: 27734
		private int phantomBattleCardId_;

		// Token: 0x04006C57 RID: 27735
		public const int IsUnlockFieldNumber = 2;

		// Token: 0x04006C58 RID: 27736
		private bool isUnlock_;

		// Token: 0x04006C59 RID: 27737
		public const int IsUnlockOutLookFieldNumber = 3;

		// Token: 0x04006C5A RID: 27738
		private bool isUnlockOutLook_;
	}
}

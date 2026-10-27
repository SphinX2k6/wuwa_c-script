using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CB8 RID: 3256
	[NetMessage(EMessageId.PhantomBattleSkillTriggerInfoNotify)]
	public sealed class PhantomBattleSkillTriggerInfoNotify : IMessage<PhantomBattleSkillTriggerInfoNotify>, IMessage, IEquatable<PhantomBattleSkillTriggerInfoNotify>, IDeepCloneable<PhantomBattleSkillTriggerInfoNotify>, IBufferMessage
	{
		// Token: 0x06011A33 RID: 72243 RVA: 0x00295413 File Offset: 0x00293613
		[NullableContext(1)]
		public static PhantomBattleSkillTriggerInfoNotify Create()
		{
			return new PhantomBattleSkillTriggerInfoNotify();
		}

		// Token: 0x17003A72 RID: 14962
		// (get) Token: 0x06011A34 RID: 72244 RVA: 0x0029541A File Offset: 0x0029361A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A73 RID: 14963
		// (get) Token: 0x06011A35 RID: 72245 RVA: 0x0029541D File Offset: 0x0029361D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleSkillTriggerInfoNotify.Descriptor;
			}
		}

		// Token: 0x06011A36 RID: 72246 RVA: 0x00295424 File Offset: 0x00293624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSkillTriggerInfoNotify()
		{
		}

		// Token: 0x06011A37 RID: 72247 RVA: 0x00295437 File Offset: 0x00293637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSkillTriggerInfoNotify(PhantomBattleSkillTriggerInfoNotify other) : this()
		{
			this.phantomBattleSkillTriggerInfos_ = other.phantomBattleSkillTriggerInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011A38 RID: 72248 RVA: 0x00295461 File Offset: 0x00293661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSkillTriggerInfoNotify Clone()
		{
			return new PhantomBattleSkillTriggerInfoNotify(this);
		}

		// Token: 0x17003A74 RID: 14964
		// (get) Token: 0x06011A39 RID: 72249 RVA: 0x00295469 File Offset: 0x00293669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleSkillTriggerInfo> PhantomBattleSkillTriggerInfos
		{
			get
			{
				return this.phantomBattleSkillTriggerInfos_;
			}
		}

		// Token: 0x06011A3A RID: 72250 RVA: 0x00295471 File Offset: 0x00293671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleSkillTriggerInfoNotify);
		}

		// Token: 0x06011A3B RID: 72251 RVA: 0x0029547F File Offset: 0x0029367F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleSkillTriggerInfoNotify other)
		{
			return other != null && (other == this || (this.phantomBattleSkillTriggerInfos_.Equals(other.phantomBattleSkillTriggerInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011A3C RID: 72252 RVA: 0x002954B4 File Offset: 0x002936B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomBattleSkillTriggerInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011A3D RID: 72253 RVA: 0x002954E8 File Offset: 0x002936E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011A3E RID: 72254 RVA: 0x002954F5 File Offset: 0x002936F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011A3F RID: 72255 RVA: 0x002954FE File Offset: 0x002936FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleSkillTriggerInfos_.WriteTo(ref output, PhantomBattleSkillTriggerInfoNotify._repeated_phantomBattleSkillTriggerInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011A40 RID: 72256 RVA: 0x00295528 File Offset: 0x00293728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomBattleSkillTriggerInfos_.CalculateSize(PhantomBattleSkillTriggerInfoNotify._repeated_phantomBattleSkillTriggerInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011A41 RID: 72257 RVA: 0x00295561 File Offset: 0x00293761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleSkillTriggerInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomBattleSkillTriggerInfos_.Add(other.phantomBattleSkillTriggerInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011A42 RID: 72258 RVA: 0x0029558F File Offset: 0x0029378F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011A43 RID: 72259 RVA: 0x00295598 File Offset: 0x00293798
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.phantomBattleSkillTriggerInfos_.AddEntriesFrom(ref input, PhantomBattleSkillTriggerInfoNotify._repeated_phantomBattleSkillTriggerInfos_codec);
				}
			}
		}

		// Token: 0x04006F12 RID: 28434
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F13 RID: 28435
		public const int PhantomBattleSkillTriggerInfosFieldNumber = 2;

		// Token: 0x04006F14 RID: 28436
		private static readonly FieldCodec<PhantomBattleSkillTriggerInfo> _repeated_phantomBattleSkillTriggerInfos_codec = FieldCodec.ForMessage<PhantomBattleSkillTriggerInfo>(18U, PhantomBattleSkillTriggerInfo.Parser);

		// Token: 0x04006F15 RID: 28437
		private readonly RepeatedField<PhantomBattleSkillTriggerInfo> phantomBattleSkillTriggerInfos_ = new RepeatedField<PhantomBattleSkillTriggerInfo>();
	}
}

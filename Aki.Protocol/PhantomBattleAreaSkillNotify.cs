using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C18 RID: 3096
	[NetMessage(EMessageId.PhantomBattleAreaSkillNotify)]
	public sealed class PhantomBattleAreaSkillNotify : IMessage<PhantomBattleAreaSkillNotify>, IMessage, IEquatable<PhantomBattleAreaSkillNotify>, IDeepCloneable<PhantomBattleAreaSkillNotify>, IBufferMessage
	{
		// Token: 0x06010D30 RID: 68912 RVA: 0x00277681 File Offset: 0x00275881
		[NullableContext(1)]
		public static PhantomBattleAreaSkillNotify Create()
		{
			return new PhantomBattleAreaSkillNotify();
		}

		// Token: 0x1700378F RID: 14223
		// (get) Token: 0x06010D31 RID: 68913 RVA: 0x00277688 File Offset: 0x00275888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003790 RID: 14224
		// (get) Token: 0x06010D32 RID: 68914 RVA: 0x0027768B File Offset: 0x0027588B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleAreaSkillNotify.Descriptor;
			}
		}

		// Token: 0x06010D33 RID: 68915 RVA: 0x00277692 File Offset: 0x00275892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAreaSkillNotify()
		{
		}

		// Token: 0x06010D34 RID: 68916 RVA: 0x0027769A File Offset: 0x0027589A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAreaSkillNotify(PhantomBattleAreaSkillNotify other) : this()
		{
			this.phantomBattleSkillTriggerInfos_ = ((other.phantomBattleSkillTriggerInfos_ != null) ? other.phantomBattleSkillTriggerInfos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010D35 RID: 68917 RVA: 0x002776CF File Offset: 0x002758CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleAreaSkillNotify Clone()
		{
			return new PhantomBattleAreaSkillNotify(this);
		}

		// Token: 0x17003791 RID: 14225
		// (get) Token: 0x06010D36 RID: 68918 RVA: 0x002776D7 File Offset: 0x002758D7
		// (set) Token: 0x06010D37 RID: 68919 RVA: 0x002776DF File Offset: 0x002758DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSkillTriggerInfo PhantomBattleSkillTriggerInfos
		{
			get
			{
				return this.phantomBattleSkillTriggerInfos_;
			}
			set
			{
				this.phantomBattleSkillTriggerInfos_ = value;
			}
		}

		// Token: 0x06010D38 RID: 68920 RVA: 0x002776E8 File Offset: 0x002758E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleAreaSkillNotify);
		}

		// Token: 0x06010D39 RID: 68921 RVA: 0x002776F6 File Offset: 0x002758F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleAreaSkillNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PhantomBattleSkillTriggerInfos, other.PhantomBattleSkillTriggerInfos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010D3A RID: 68922 RVA: 0x0027772C File Offset: 0x0027592C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.phantomBattleSkillTriggerInfos_ != null)
			{
				num ^= this.PhantomBattleSkillTriggerInfos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010D3B RID: 68923 RVA: 0x00277768 File Offset: 0x00275968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010D3C RID: 68924 RVA: 0x00277775 File Offset: 0x00275975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010D3D RID: 68925 RVA: 0x0027777E File Offset: 0x0027597E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.phantomBattleSkillTriggerInfos_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.PhantomBattleSkillTriggerInfos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010D3E RID: 68926 RVA: 0x002777B0 File Offset: 0x002759B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.phantomBattleSkillTriggerInfos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleSkillTriggerInfos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010D3F RID: 68927 RVA: 0x002777F0 File Offset: 0x002759F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleAreaSkillNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.phantomBattleSkillTriggerInfos_ != null)
			{
				if (this.phantomBattleSkillTriggerInfos_ == null)
				{
					this.PhantomBattleSkillTriggerInfos = new PhantomBattleSkillTriggerInfo();
				}
				this.PhantomBattleSkillTriggerInfos.MergeFrom(other.PhantomBattleSkillTriggerInfos);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010D40 RID: 68928 RVA: 0x00277844 File Offset: 0x00275A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010D41 RID: 68929 RVA: 0x00277850 File Offset: 0x00275A50
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.phantomBattleSkillTriggerInfos_ == null)
					{
						this.PhantomBattleSkillTriggerInfos = new PhantomBattleSkillTriggerInfo();
					}
					input.ReadMessage(this.PhantomBattleSkillTriggerInfos);
				}
			}
		}

		// Token: 0x04006B4E RID: 27470
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B4F RID: 27471
		public const int PhantomBattleSkillTriggerInfosFieldNumber = 10;

		// Token: 0x04006B50 RID: 27472
		private PhantomBattleSkillTriggerInfo phantomBattleSkillTriggerInfos_;
	}
}

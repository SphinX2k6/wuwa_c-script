using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001032 RID: 4146
	public sealed class RogueWeeklyBuff : IMessage<RogueWeeklyBuff>, IMessage, IEquatable<RogueWeeklyBuff>, IDeepCloneable<RogueWeeklyBuff>, IBufferMessage
	{
		// Token: 0x06016281 RID: 90753 RVA: 0x0033801F File Offset: 0x0033621F
		[NullableContext(1)]
		public static RogueWeeklyBuff Create()
		{
			return new RogueWeeklyBuff();
		}

		// Token: 0x17004A0E RID: 18958
		// (get) Token: 0x06016282 RID: 90754 RVA: 0x00338026 File Offset: 0x00336226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A0F RID: 18959
		// (get) Token: 0x06016283 RID: 90755 RVA: 0x00338029 File Offset: 0x00336229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyBuff.Descriptor;
			}
		}

		// Token: 0x06016284 RID: 90756 RVA: 0x00338030 File Offset: 0x00336230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyBuff()
		{
		}

		// Token: 0x06016285 RID: 90757 RVA: 0x00338038 File Offset: 0x00336238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyBuff(RogueWeeklyBuff other) : this()
		{
			this.isNew_ = other.isNew_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016286 RID: 90758 RVA: 0x0033805D File Offset: 0x0033625D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyBuff Clone()
		{
			return new RogueWeeklyBuff(this);
		}

		// Token: 0x17004A10 RID: 18960
		// (get) Token: 0x06016287 RID: 90759 RVA: 0x00338065 File Offset: 0x00336265
		// (set) Token: 0x06016288 RID: 90760 RVA: 0x0033806D File Offset: 0x0033626D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNew
		{
			get
			{
				return this.isNew_;
			}
			set
			{
				this.isNew_ = value;
			}
		}

		// Token: 0x06016289 RID: 90761 RVA: 0x00338076 File Offset: 0x00336276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyBuff);
		}

		// Token: 0x0601628A RID: 90762 RVA: 0x00338084 File Offset: 0x00336284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyBuff other)
		{
			return other != null && (other == this || (this.IsNew == other.IsNew && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601628B RID: 90763 RVA: 0x003380B4 File Offset: 0x003362B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsNew)
			{
				num ^= this.IsNew.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601628C RID: 90764 RVA: 0x003380F3 File Offset: 0x003362F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601628D RID: 90765 RVA: 0x00338100 File Offset: 0x00336300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601628E RID: 90766 RVA: 0x00338109 File Offset: 0x00336309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsNew)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsNew);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601628F RID: 90767 RVA: 0x0033813C File Offset: 0x0033633C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsNew)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016290 RID: 90768 RVA: 0x0033816E File Offset: 0x0033636E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyBuff other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsNew)
			{
				this.IsNew = other.IsNew;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016291 RID: 90769 RVA: 0x0033819F File Offset: 0x0033639F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016292 RID: 90770 RVA: 0x003381A8 File Offset: 0x003363A8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IsNew = input.ReadBool();
				}
			}
		}

		// Token: 0x040084A2 RID: 33954
		private UnknownFieldSet _unknownFields;

		// Token: 0x040084A3 RID: 33955
		public const int IsNewFieldNumber = 1;

		// Token: 0x040084A4 RID: 33956
		private bool isNew_;
	}
}

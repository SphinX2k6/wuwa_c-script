using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000FC RID: 252
	[NetMessage(EMessageId.AppGradeNotify)]
	public sealed class AppGradeNotify : IMessage<AppGradeNotify>, IMessage, IEquatable<AppGradeNotify>, IDeepCloneable<AppGradeNotify>, IBufferMessage
	{
		// Token: 0x060023C5 RID: 9157 RVA: 0x0005F653 File Offset: 0x0005D853
		[NullableContext(1)]
		public static AppGradeNotify Create()
		{
			return new AppGradeNotify();
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x060023C6 RID: 9158 RVA: 0x0005F65A File Offset: 0x0005D85A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x060023C7 RID: 9159 RVA: 0x0005F65D File Offset: 0x0005D85D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AppGradeNotify.Descriptor;
			}
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x0005F664 File Offset: 0x0005D864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AppGradeNotify()
		{
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x0005F66C File Offset: 0x0005D86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AppGradeNotify(AppGradeNotify other) : this()
		{
			this.id_ = other.id_;
			this.delay_ = other.delay_;
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x0005F6A9 File Offset: 0x0005D8A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AppGradeNotify Clone()
		{
			return new AppGradeNotify(this);
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x060023CB RID: 9163 RVA: 0x0005F6B1 File Offset: 0x0005D8B1
		// (set) Token: 0x060023CC RID: 9164 RVA: 0x0005F6B9 File Offset: 0x0005D8B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x060023CD RID: 9165 RVA: 0x0005F6C2 File Offset: 0x0005D8C2
		// (set) Token: 0x060023CE RID: 9166 RVA: 0x0005F6CA File Offset: 0x0005D8CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Delay
		{
			get
			{
				return this.delay_;
			}
			set
			{
				this.delay_ = value;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x060023CF RID: 9167 RVA: 0x0005F6D3 File Offset: 0x0005D8D3
		// (set) Token: 0x060023D0 RID: 9168 RVA: 0x0005F6DB File Offset: 0x0005D8DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x0005F6E4 File Offset: 0x0005D8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AppGradeNotify);
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x0005F6F4 File Offset: 0x0005D8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AppGradeNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Delay == other.Delay && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x0005F750 File Offset: 0x0005D950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Delay != 0)
			{
				num ^= this.Delay.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x0005F7C1 File Offset: 0x0005D9C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x0005F7CE File Offset: 0x0005D9CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x0005F7D8 File Offset: 0x0005D9D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Type);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Id);
			}
			if (this.Delay != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Delay);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x0005F850 File Offset: 0x0005DA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Delay != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Delay);
			}
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x0005F8C0 File Offset: 0x0005DAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AppGradeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Delay != 0)
			{
				this.Delay = other.Delay;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x0005F924 File Offset: 0x0005DB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x0005F930 File Offset: 0x0005DB30
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
				if (num != 32U)
				{
					if (num != 96U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Delay = input.ReadInt32();
						}
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.Type = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400255B RID: 9563
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400255C RID: 9564
		public const int IdFieldNumber = 12;

		// Token: 0x0400255D RID: 9565
		private int id_;

		// Token: 0x0400255E RID: 9566
		public const int DelayFieldNumber = 15;

		// Token: 0x0400255F RID: 9567
		private int delay_;

		// Token: 0x04002560 RID: 9568
		public const int TypeFieldNumber = 4;

		// Token: 0x04002561 RID: 9569
		private int type_;
	}
}

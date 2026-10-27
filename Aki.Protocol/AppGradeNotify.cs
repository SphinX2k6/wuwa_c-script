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
		// Token: 0x0600238E RID: 9102 RVA: 0x0005EB83 File Offset: 0x0005CD83
		[NullableContext(1)]
		public static AppGradeNotify Create()
		{
			return new AppGradeNotify();
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x0600238F RID: 9103 RVA: 0x0005EB8A File Offset: 0x0005CD8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06002390 RID: 9104 RVA: 0x0005EB8D File Offset: 0x0005CD8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AppGradeNotify.Descriptor;
			}
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x0005EB94 File Offset: 0x0005CD94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AppGradeNotify()
		{
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x0005EB9C File Offset: 0x0005CD9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AppGradeNotify(AppGradeNotify other) : this()
		{
			this.id_ = other.id_;
			this.delay_ = other.delay_;
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002393 RID: 9107 RVA: 0x0005EBD9 File Offset: 0x0005CDD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AppGradeNotify Clone()
		{
			return new AppGradeNotify(this);
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06002394 RID: 9108 RVA: 0x0005EBE1 File Offset: 0x0005CDE1
		// (set) Token: 0x06002395 RID: 9109 RVA: 0x0005EBE9 File Offset: 0x0005CDE9
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

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06002396 RID: 9110 RVA: 0x0005EBF2 File Offset: 0x0005CDF2
		// (set) Token: 0x06002397 RID: 9111 RVA: 0x0005EBFA File Offset: 0x0005CDFA
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

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06002398 RID: 9112 RVA: 0x0005EC03 File Offset: 0x0005CE03
		// (set) Token: 0x06002399 RID: 9113 RVA: 0x0005EC0B File Offset: 0x0005CE0B
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

		// Token: 0x0600239A RID: 9114 RVA: 0x0005EC14 File Offset: 0x0005CE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AppGradeNotify);
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x0005EC24 File Offset: 0x0005CE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AppGradeNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Delay == other.Delay && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x0005EC80 File Offset: 0x0005CE80
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

		// Token: 0x0600239D RID: 9117 RVA: 0x0005ECF1 File Offset: 0x0005CEF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x0005ECFE File Offset: 0x0005CEFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x0005ED08 File Offset: 0x0005CF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Type != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Type);
			}
			if (this.Delay != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Delay);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x0005ED7C File Offset: 0x0005CF7C
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

		// Token: 0x060023A1 RID: 9121 RVA: 0x0005EDEC File Offset: 0x0005CFEC
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

		// Token: 0x060023A2 RID: 9122 RVA: 0x0005EE50 File Offset: 0x0005D050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x0005EE5C File Offset: 0x0005D05C
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
						if (num != 112U)
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
						this.Type = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040024FC RID: 9468
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024FD RID: 9469
		public const int IdFieldNumber = 1;

		// Token: 0x040024FE RID: 9470
		private int id_;

		// Token: 0x040024FF RID: 9471
		public const int DelayFieldNumber = 14;

		// Token: 0x04002500 RID: 9472
		private int delay_;

		// Token: 0x04002501 RID: 9473
		public const int TypeFieldNumber = 5;

		// Token: 0x04002502 RID: 9474
		private int type_;
	}
}

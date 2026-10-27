using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003D8 RID: 984
	[NetMessage(EMessageId.DieSwitchRoleNotify)]
	public sealed class DieSwitchRoleNotify : IMessage<DieSwitchRoleNotify>, IMessage, IEquatable<DieSwitchRoleNotify>, IDeepCloneable<DieSwitchRoleNotify>, IBufferMessage
	{
		// Token: 0x06005FE7 RID: 24551 RVA: 0x000E82F4 File Offset: 0x000E64F4
		[NullableContext(1)]
		public static DieSwitchRoleNotify Create()
		{
			return new DieSwitchRoleNotify();
		}

		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x06005FE8 RID: 24552 RVA: 0x000E82FB File Offset: 0x000E64FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x06005FE9 RID: 24553 RVA: 0x000E82FE File Offset: 0x000E64FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DieSwitchRoleNotify.Descriptor;
			}
		}

		// Token: 0x06005FEA RID: 24554 RVA: 0x000E8305 File Offset: 0x000E6505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DieSwitchRoleNotify()
		{
		}

		// Token: 0x06005FEB RID: 24555 RVA: 0x000E830D File Offset: 0x000E650D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DieSwitchRoleNotify(DieSwitchRoleNotify other) : this()
		{
			this.curRoleId_ = other.curRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005FEC RID: 24556 RVA: 0x000E8332 File Offset: 0x000E6532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DieSwitchRoleNotify Clone()
		{
			return new DieSwitchRoleNotify(this);
		}

		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x06005FED RID: 24557 RVA: 0x000E833A File Offset: 0x000E653A
		// (set) Token: 0x06005FEE RID: 24558 RVA: 0x000E8342 File Offset: 0x000E6542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurRoleId
		{
			get
			{
				return this.curRoleId_;
			}
			set
			{
				this.curRoleId_ = value;
			}
		}

		// Token: 0x06005FEF RID: 24559 RVA: 0x000E834B File Offset: 0x000E654B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DieSwitchRoleNotify);
		}

		// Token: 0x06005FF0 RID: 24560 RVA: 0x000E8359 File Offset: 0x000E6559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DieSwitchRoleNotify other)
		{
			return other != null && (other == this || (this.CurRoleId == other.CurRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005FF1 RID: 24561 RVA: 0x000E8388 File Offset: 0x000E6588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurRoleId != 0)
			{
				num ^= this.CurRoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005FF2 RID: 24562 RVA: 0x000E83C7 File Offset: 0x000E65C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005FF3 RID: 24563 RVA: 0x000E83D4 File Offset: 0x000E65D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005FF4 RID: 24564 RVA: 0x000E83DD File Offset: 0x000E65DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurRoleId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.CurRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005FF5 RID: 24565 RVA: 0x000E8410 File Offset: 0x000E6610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurRoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005FF6 RID: 24566 RVA: 0x000E844E File Offset: 0x000E664E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DieSwitchRoleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurRoleId != 0)
			{
				this.CurRoleId = other.CurRoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005FF7 RID: 24567 RVA: 0x000E847F File Offset: 0x000E667F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005FF8 RID: 24568 RVA: 0x000E8488 File Offset: 0x000E6688
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CurRoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003746 RID: 14150
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003747 RID: 14151
		public const int CurRoleIdFieldNumber = 15;

		// Token: 0x04003748 RID: 14152
		private int curRoleId_;
	}
}

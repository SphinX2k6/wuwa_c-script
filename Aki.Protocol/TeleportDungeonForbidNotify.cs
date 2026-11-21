using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013AB RID: 5035
	[NetMessage(EMessageId.TeleportDungeonForbidNotify)]
	public sealed class TeleportDungeonForbidNotify : IMessage<TeleportDungeonForbidNotify>, IMessage, IEquatable<TeleportDungeonForbidNotify>, IDeepCloneable<TeleportDungeonForbidNotify>, IBufferMessage
	{
		// Token: 0x0601ACC2 RID: 109762 RVA: 0x003E7050 File Offset: 0x003E5250
		[NullableContext(1)]
		public static TeleportDungeonForbidNotify Create()
		{
			return new TeleportDungeonForbidNotify();
		}

		// Token: 0x17005ABC RID: 23228
		// (get) Token: 0x0601ACC3 RID: 109763 RVA: 0x003E7057 File Offset: 0x003E5257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005ABD RID: 23229
		// (get) Token: 0x0601ACC4 RID: 109764 RVA: 0x003E705A File Offset: 0x003E525A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportDungeonForbidNotify.Descriptor;
			}
		}

		// Token: 0x0601ACC5 RID: 109765 RVA: 0x003E7061 File Offset: 0x003E5261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDungeonForbidNotify()
		{
		}

		// Token: 0x0601ACC6 RID: 109766 RVA: 0x003E7069 File Offset: 0x003E5269
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDungeonForbidNotify(TeleportDungeonForbidNotify other) : this()
		{
			this.dungeonId_ = other.dungeonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ACC7 RID: 109767 RVA: 0x003E708E File Offset: 0x003E528E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportDungeonForbidNotify Clone()
		{
			return new TeleportDungeonForbidNotify(this);
		}

		// Token: 0x17005ABE RID: 23230
		// (get) Token: 0x0601ACC8 RID: 109768 RVA: 0x003E7096 File Offset: 0x003E5296
		// (set) Token: 0x0601ACC9 RID: 109769 RVA: 0x003E709E File Offset: 0x003E529E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DungeonId
		{
			get
			{
				return this.dungeonId_;
			}
			set
			{
				this.dungeonId_ = value;
			}
		}

		// Token: 0x0601ACCA RID: 109770 RVA: 0x003E70A7 File Offset: 0x003E52A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportDungeonForbidNotify);
		}

		// Token: 0x0601ACCB RID: 109771 RVA: 0x003E70B5 File Offset: 0x003E52B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportDungeonForbidNotify other)
		{
			return other != null && (other == this || (this.DungeonId == other.DungeonId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601ACCC RID: 109772 RVA: 0x003E70E4 File Offset: 0x003E52E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DungeonId != 0)
			{
				num ^= this.DungeonId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601ACCD RID: 109773 RVA: 0x003E7123 File Offset: 0x003E5323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ACCE RID: 109774 RVA: 0x003E7130 File Offset: 0x003E5330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ACCF RID: 109775 RVA: 0x003E7139 File Offset: 0x003E5339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DungeonId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.DungeonId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601ACD0 RID: 109776 RVA: 0x003E716C File Offset: 0x003E536C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DungeonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DungeonId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601ACD1 RID: 109777 RVA: 0x003E71AA File Offset: 0x003E53AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportDungeonForbidNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DungeonId != 0)
			{
				this.DungeonId = other.DungeonId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601ACD2 RID: 109778 RVA: 0x003E71DB File Offset: 0x003E53DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ACD3 RID: 109779 RVA: 0x003E71E4 File Offset: 0x003E53E4
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
					this.DungeonId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009CCF RID: 40143
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009CD0 RID: 40144
		public const int DungeonIdFieldNumber = 15;

		// Token: 0x04009CD1 RID: 40145
		private int dungeonId_;
	}
}

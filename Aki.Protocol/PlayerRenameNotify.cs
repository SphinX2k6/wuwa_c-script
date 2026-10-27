using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DA7 RID: 3495
	[NetMessage(EMessageId.PlayerRenameNotify)]
	public sealed class PlayerRenameNotify : IMessage<PlayerRenameNotify>, IMessage, IEquatable<PlayerRenameNotify>, IDeepCloneable<PlayerRenameNotify>, IBufferMessage
	{
		// Token: 0x06012D44 RID: 77124 RVA: 0x002BEE5D File Offset: 0x002BD05D
		[NullableContext(1)]
		public static PlayerRenameNotify Create()
		{
			return new PlayerRenameNotify();
		}

		// Token: 0x17003E75 RID: 15989
		// (get) Token: 0x06012D45 RID: 77125 RVA: 0x002BEE64 File Offset: 0x002BD064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E76 RID: 15990
		// (get) Token: 0x06012D46 RID: 77126 RVA: 0x002BEE67 File Offset: 0x002BD067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerRenameNotify.Descriptor;
			}
		}

		// Token: 0x06012D47 RID: 77127 RVA: 0x002BEE6E File Offset: 0x002BD06E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRenameNotify()
		{
		}

		// Token: 0x06012D48 RID: 77128 RVA: 0x002BEE81 File Offset: 0x002BD081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRenameNotify(PlayerRenameNotify other) : this()
		{
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012D49 RID: 77129 RVA: 0x002BEEA6 File Offset: 0x002BD0A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerRenameNotify Clone()
		{
			return new PlayerRenameNotify(this);
		}

		// Token: 0x17003E77 RID: 15991
		// (get) Token: 0x06012D4A RID: 77130 RVA: 0x002BEEAE File Offset: 0x002BD0AE
		// (set) Token: 0x06012D4B RID: 77131 RVA: 0x002BEEB6 File Offset: 0x002BD0B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06012D4C RID: 77132 RVA: 0x002BEEC9 File Offset: 0x002BD0C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerRenameNotify);
		}

		// Token: 0x06012D4D RID: 77133 RVA: 0x002BEED7 File Offset: 0x002BD0D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerRenameNotify other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012D4E RID: 77134 RVA: 0x002BEF0C File Offset: 0x002BD10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012D4F RID: 77135 RVA: 0x002BEF4D File Offset: 0x002BD14D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012D50 RID: 77136 RVA: 0x002BEF5A File Offset: 0x002BD15A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012D51 RID: 77137 RVA: 0x002BEF63 File Offset: 0x002BD163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.Name);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012D52 RID: 77138 RVA: 0x002BEF9C File Offset: 0x002BD19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012D53 RID: 77139 RVA: 0x002BEFDF File Offset: 0x002BD1DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerRenameNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012D54 RID: 77140 RVA: 0x002BF015 File Offset: 0x002BD215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012D55 RID: 77141 RVA: 0x002BF020 File Offset: 0x002BD220
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Name = input.ReadString();
				}
			}
		}

		// Token: 0x04007486 RID: 29830
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007487 RID: 29831
		public const int NameFieldNumber = 11;

		// Token: 0x04007488 RID: 29832
		private string name_ = "";
	}
}

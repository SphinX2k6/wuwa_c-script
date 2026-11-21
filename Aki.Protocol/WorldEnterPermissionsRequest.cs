using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200158E RID: 5518
	[NetMessage(EMessageId.WorldEnterPermissionsRequest)]
	public sealed class WorldEnterPermissionsRequest : IMessage<WorldEnterPermissionsRequest>, IMessage, IEquatable<WorldEnterPermissionsRequest>, IDeepCloneable<WorldEnterPermissionsRequest>, IBufferMessage
	{
		// Token: 0x0601D354 RID: 119636 RVA: 0x0043A6BD File Offset: 0x004388BD
		[NullableContext(1)]
		public static WorldEnterPermissionsRequest Create()
		{
			return new WorldEnterPermissionsRequest();
		}

		// Token: 0x170062CE RID: 25294
		// (get) Token: 0x0601D355 RID: 119637 RVA: 0x0043A6C4 File Offset: 0x004388C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062CF RID: 25295
		// (get) Token: 0x0601D356 RID: 119638 RVA: 0x0043A6C7 File Offset: 0x004388C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorldEnterPermissionsRequest.Descriptor;
			}
		}

		// Token: 0x0601D357 RID: 119639 RVA: 0x0043A6CE File Offset: 0x004388CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldEnterPermissionsRequest()
		{
		}

		// Token: 0x0601D358 RID: 119640 RVA: 0x0043A6D6 File Offset: 0x004388D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldEnterPermissionsRequest(WorldEnterPermissionsRequest other) : this()
		{
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D359 RID: 119641 RVA: 0x0043A6FB File Offset: 0x004388FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldEnterPermissionsRequest Clone()
		{
			return new WorldEnterPermissionsRequest(this);
		}

		// Token: 0x170062D0 RID: 25296
		// (get) Token: 0x0601D35A RID: 119642 RVA: 0x0043A703 File Offset: 0x00438903
		// (set) Token: 0x0601D35B RID: 119643 RVA: 0x0043A70B File Offset: 0x0043890B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldEnterPermission Type
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

		// Token: 0x0601D35C RID: 119644 RVA: 0x0043A714 File Offset: 0x00438914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorldEnterPermissionsRequest);
		}

		// Token: 0x0601D35D RID: 119645 RVA: 0x0043A722 File Offset: 0x00438922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorldEnterPermissionsRequest other)
		{
			return other != null && (other == this || (this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D35E RID: 119646 RVA: 0x0043A750 File Offset: 0x00438950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != WorldEnterPermission.ConfirmJoin)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D35F RID: 119647 RVA: 0x0043A795 File Offset: 0x00438995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D360 RID: 119648 RVA: 0x0043A7A2 File Offset: 0x004389A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D361 RID: 119649 RVA: 0x0043A7AB File Offset: 0x004389AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != WorldEnterPermission.ConfirmJoin)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D362 RID: 119650 RVA: 0x0043A7E0 File Offset: 0x004389E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != WorldEnterPermission.ConfirmJoin)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D363 RID: 119651 RVA: 0x0043A81E File Offset: 0x00438A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WorldEnterPermissionsRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != WorldEnterPermission.ConfirmJoin)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D364 RID: 119652 RVA: 0x0043A84F File Offset: 0x00438A4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D365 RID: 119653 RVA: 0x0043A858 File Offset: 0x00438A58
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Type = (WorldEnterPermission)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A78E RID: 42894
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A78F RID: 42895
		public const int TypeFieldNumber = 8;

		// Token: 0x0400A790 RID: 42896
		private WorldEnterPermission type_;
	}
}

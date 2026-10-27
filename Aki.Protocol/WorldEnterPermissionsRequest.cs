using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001518 RID: 5400
	[NetMessage(EMessageId.WorldEnterPermissionsRequest)]
	public sealed class WorldEnterPermissionsRequest : IMessage<WorldEnterPermissionsRequest>, IMessage, IEquatable<WorldEnterPermissionsRequest>, IDeepCloneable<WorldEnterPermissionsRequest>, IBufferMessage
	{
		// Token: 0x0601C88D RID: 116877 RVA: 0x0041EBFD File Offset: 0x0041CDFD
		[NullableContext(1)]
		public static WorldEnterPermissionsRequest Create()
		{
			return new WorldEnterPermissionsRequest();
		}

		// Token: 0x1700602D RID: 24621
		// (get) Token: 0x0601C88E RID: 116878 RVA: 0x0041EC04 File Offset: 0x0041CE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700602E RID: 24622
		// (get) Token: 0x0601C88F RID: 116879 RVA: 0x0041EC07 File Offset: 0x0041CE07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WorldEnterPermissionsRequest.Descriptor;
			}
		}

		// Token: 0x0601C890 RID: 116880 RVA: 0x0041EC0E File Offset: 0x0041CE0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldEnterPermissionsRequest()
		{
		}

		// Token: 0x0601C891 RID: 116881 RVA: 0x0041EC16 File Offset: 0x0041CE16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldEnterPermissionsRequest(WorldEnterPermissionsRequest other) : this()
		{
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C892 RID: 116882 RVA: 0x0041EC3B File Offset: 0x0041CE3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WorldEnterPermissionsRequest Clone()
		{
			return new WorldEnterPermissionsRequest(this);
		}

		// Token: 0x1700602F RID: 24623
		// (get) Token: 0x0601C893 RID: 116883 RVA: 0x0041EC43 File Offset: 0x0041CE43
		// (set) Token: 0x0601C894 RID: 116884 RVA: 0x0041EC4B File Offset: 0x0041CE4B
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

		// Token: 0x0601C895 RID: 116885 RVA: 0x0041EC54 File Offset: 0x0041CE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WorldEnterPermissionsRequest);
		}

		// Token: 0x0601C896 RID: 116886 RVA: 0x0041EC62 File Offset: 0x0041CE62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WorldEnterPermissionsRequest other)
		{
			return other != null && (other == this || (this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C897 RID: 116887 RVA: 0x0041EC90 File Offset: 0x0041CE90
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

		// Token: 0x0601C898 RID: 116888 RVA: 0x0041ECD5 File Offset: 0x0041CED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C899 RID: 116889 RVA: 0x0041ECE2 File Offset: 0x0041CEE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C89A RID: 116890 RVA: 0x0041ECEB File Offset: 0x0041CEEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != WorldEnterPermission.ConfirmJoin)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C89B RID: 116891 RVA: 0x0041ED20 File Offset: 0x0041CF20
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

		// Token: 0x0601C89C RID: 116892 RVA: 0x0041ED5E File Offset: 0x0041CF5E
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

		// Token: 0x0601C89D RID: 116893 RVA: 0x0041ED8F File Offset: 0x0041CF8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C89E RID: 116894 RVA: 0x0041ED98 File Offset: 0x0041CF98
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Type = (WorldEnterPermission)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A335 RID: 41781
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A336 RID: 41782
		public const int TypeFieldNumber = 11;

		// Token: 0x0400A337 RID: 41783
		private WorldEnterPermission type_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001200 RID: 4608
	[NetMessage(EMessageId.ServerConfigVersionInfoNotify)]
	public sealed class ServerConfigVersionInfoNotify : IMessage<ServerConfigVersionInfoNotify>, IMessage, IEquatable<ServerConfigVersionInfoNotify>, IDeepCloneable<ServerConfigVersionInfoNotify>, IBufferMessage
	{
		// Token: 0x06018A01 RID: 100865 RVA: 0x003979ED File Offset: 0x00395BED
		[NullableContext(1)]
		public static ServerConfigVersionInfoNotify Create()
		{
			return new ServerConfigVersionInfoNotify();
		}

		// Token: 0x1700532F RID: 21295
		// (get) Token: 0x06018A02 RID: 100866 RVA: 0x003979F4 File Offset: 0x00395BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005330 RID: 21296
		// (get) Token: 0x06018A03 RID: 100867 RVA: 0x003979F7 File Offset: 0x00395BF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ServerConfigVersionInfoNotify.Descriptor;
			}
		}

		// Token: 0x06018A04 RID: 100868 RVA: 0x003979FE File Offset: 0x00395BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServerConfigVersionInfoNotify()
		{
		}

		// Token: 0x06018A05 RID: 100869 RVA: 0x00397A06 File Offset: 0x00395C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServerConfigVersionInfoNotify(ServerConfigVersionInfoNotify other) : this()
		{
			this.universeEditor_ = other.universeEditor_;
			this.publicJson_ = other.publicJson_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018A06 RID: 100870 RVA: 0x00397A37 File Offset: 0x00395C37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServerConfigVersionInfoNotify Clone()
		{
			return new ServerConfigVersionInfoNotify(this);
		}

		// Token: 0x17005331 RID: 21297
		// (get) Token: 0x06018A07 RID: 100871 RVA: 0x00397A3F File Offset: 0x00395C3F
		// (set) Token: 0x06018A08 RID: 100872 RVA: 0x00397A47 File Offset: 0x00395C47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UniverseEditor
		{
			get
			{
				return this.universeEditor_;
			}
			set
			{
				this.universeEditor_ = value;
			}
		}

		// Token: 0x17005332 RID: 21298
		// (get) Token: 0x06018A09 RID: 100873 RVA: 0x00397A50 File Offset: 0x00395C50
		// (set) Token: 0x06018A0A RID: 100874 RVA: 0x00397A58 File Offset: 0x00395C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PublicJson
		{
			get
			{
				return this.publicJson_;
			}
			set
			{
				this.publicJson_ = value;
			}
		}

		// Token: 0x06018A0B RID: 100875 RVA: 0x00397A61 File Offset: 0x00395C61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ServerConfigVersionInfoNotify);
		}

		// Token: 0x06018A0C RID: 100876 RVA: 0x00397A6F File Offset: 0x00395C6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ServerConfigVersionInfoNotify other)
		{
			return other != null && (other == this || (this.UniverseEditor == other.UniverseEditor && this.PublicJson == other.PublicJson && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018A0D RID: 100877 RVA: 0x00397AB0 File Offset: 0x00395CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.UniverseEditor != 0)
			{
				num ^= this.UniverseEditor.GetHashCode();
			}
			if (this.PublicJson != 0)
			{
				num ^= this.PublicJson.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018A0E RID: 100878 RVA: 0x00397B08 File Offset: 0x00395D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018A0F RID: 100879 RVA: 0x00397B15 File Offset: 0x00395D15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018A10 RID: 100880 RVA: 0x00397B20 File Offset: 0x00395D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PublicJson != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PublicJson);
			}
			if (this.UniverseEditor != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.UniverseEditor);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018A11 RID: 100881 RVA: 0x00397B7C File Offset: 0x00395D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.UniverseEditor != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UniverseEditor);
			}
			if (this.PublicJson != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PublicJson);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018A12 RID: 100882 RVA: 0x00397BD4 File Offset: 0x00395DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ServerConfigVersionInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.UniverseEditor != 0)
			{
				this.UniverseEditor = other.UniverseEditor;
			}
			if (other.PublicJson != 0)
			{
				this.PublicJson = other.PublicJson;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018A13 RID: 100883 RVA: 0x00397C24 File Offset: 0x00395E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018A14 RID: 100884 RVA: 0x00397C30 File Offset: 0x00395E30
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
				if (num != 24U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.UniverseEditor = input.ReadInt32();
					}
				}
				else
				{
					this.PublicJson = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009269 RID: 37481
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400926A RID: 37482
		public const int UniverseEditorFieldNumber = 12;

		// Token: 0x0400926B RID: 37483
		private int universeEditor_;

		// Token: 0x0400926C RID: 37484
		public const int PublicJsonFieldNumber = 3;

		// Token: 0x0400926D RID: 37485
		private int publicJson_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011C6 RID: 4550
	[NetMessage(EMessageId.ServerConfigVersionInfoNotify)]
	public sealed class ServerConfigVersionInfoNotify : IMessage<ServerConfigVersionInfoNotify>, IMessage, IEquatable<ServerConfigVersionInfoNotify>, IDeepCloneable<ServerConfigVersionInfoNotify>, IBufferMessage
	{
		// Token: 0x06018460 RID: 99424 RVA: 0x003886B9 File Offset: 0x003868B9
		[NullableContext(1)]
		public static ServerConfigVersionInfoNotify Create()
		{
			return new ServerConfigVersionInfoNotify();
		}

		// Token: 0x170051C3 RID: 20931
		// (get) Token: 0x06018461 RID: 99425 RVA: 0x003886C0 File Offset: 0x003868C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051C4 RID: 20932
		// (get) Token: 0x06018462 RID: 99426 RVA: 0x003886C3 File Offset: 0x003868C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ServerConfigVersionInfoNotify.Descriptor;
			}
		}

		// Token: 0x06018463 RID: 99427 RVA: 0x003886CA File Offset: 0x003868CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServerConfigVersionInfoNotify()
		{
		}

		// Token: 0x06018464 RID: 99428 RVA: 0x003886D2 File Offset: 0x003868D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServerConfigVersionInfoNotify(ServerConfigVersionInfoNotify other) : this()
		{
			this.universeEditor_ = other.universeEditor_;
			this.publicJson_ = other.publicJson_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018465 RID: 99429 RVA: 0x00388703 File Offset: 0x00386903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServerConfigVersionInfoNotify Clone()
		{
			return new ServerConfigVersionInfoNotify(this);
		}

		// Token: 0x170051C5 RID: 20933
		// (get) Token: 0x06018466 RID: 99430 RVA: 0x0038870B File Offset: 0x0038690B
		// (set) Token: 0x06018467 RID: 99431 RVA: 0x00388713 File Offset: 0x00386913
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

		// Token: 0x170051C6 RID: 20934
		// (get) Token: 0x06018468 RID: 99432 RVA: 0x0038871C File Offset: 0x0038691C
		// (set) Token: 0x06018469 RID: 99433 RVA: 0x00388724 File Offset: 0x00386924
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

		// Token: 0x0601846A RID: 99434 RVA: 0x0038872D File Offset: 0x0038692D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ServerConfigVersionInfoNotify);
		}

		// Token: 0x0601846B RID: 99435 RVA: 0x0038873B File Offset: 0x0038693B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ServerConfigVersionInfoNotify other)
		{
			return other != null && (other == this || (this.UniverseEditor == other.UniverseEditor && this.PublicJson == other.PublicJson && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601846C RID: 99436 RVA: 0x0038877C File Offset: 0x0038697C
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

		// Token: 0x0601846D RID: 99437 RVA: 0x003887D4 File Offset: 0x003869D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601846E RID: 99438 RVA: 0x003887E1 File Offset: 0x003869E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601846F RID: 99439 RVA: 0x003887EC File Offset: 0x003869EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PublicJson != 0)
			{
				output.WriteRawTag(88);
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

		// Token: 0x06018470 RID: 99440 RVA: 0x00388848 File Offset: 0x00386A48
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

		// Token: 0x06018471 RID: 99441 RVA: 0x003888A0 File Offset: 0x00386AA0
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

		// Token: 0x06018472 RID: 99442 RVA: 0x003888F0 File Offset: 0x00386AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018473 RID: 99443 RVA: 0x003888FC File Offset: 0x00386AFC
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

		// Token: 0x04008FD6 RID: 36822
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FD7 RID: 36823
		public const int UniverseEditorFieldNumber = 12;

		// Token: 0x04008FD8 RID: 36824
		private int universeEditor_;

		// Token: 0x04008FD9 RID: 36825
		public const int PublicJsonFieldNumber = 11;

		// Token: 0x04008FDA RID: 36826
		private int publicJson_;
	}
}

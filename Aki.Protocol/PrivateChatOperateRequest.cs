using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DE2 RID: 3554
	[NetMessage(EMessageId.PrivateChatOperateRequest)]
	public sealed class PrivateChatOperateRequest : IMessage<PrivateChatOperateRequest>, IMessage, IEquatable<PrivateChatOperateRequest>, IDeepCloneable<PrivateChatOperateRequest>, IBufferMessage
	{
		// Token: 0x060131F2 RID: 78322 RVA: 0x002C9107 File Offset: 0x002C7307
		[NullableContext(1)]
		public static PrivateChatOperateRequest Create()
		{
			return new PrivateChatOperateRequest();
		}

		// Token: 0x17003F6F RID: 16239
		// (get) Token: 0x060131F3 RID: 78323 RVA: 0x002C910E File Offset: 0x002C730E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F70 RID: 16240
		// (get) Token: 0x060131F4 RID: 78324 RVA: 0x002C9111 File Offset: 0x002C7311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivateChatOperateRequest.Descriptor;
			}
		}

		// Token: 0x060131F5 RID: 78325 RVA: 0x002C9118 File Offset: 0x002C7318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatOperateRequest()
		{
		}

		// Token: 0x060131F6 RID: 78326 RVA: 0x002C9120 File Offset: 0x002C7320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatOperateRequest(PrivateChatOperateRequest other) : this()
		{
			this.operateType_ = other.operateType_;
			this.tarPlayerId_ = other.tarPlayerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060131F7 RID: 78327 RVA: 0x002C9151 File Offset: 0x002C7351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatOperateRequest Clone()
		{
			return new PrivateChatOperateRequest(this);
		}

		// Token: 0x17003F71 RID: 16241
		// (get) Token: 0x060131F8 RID: 78328 RVA: 0x002C9159 File Offset: 0x002C7359
		// (set) Token: 0x060131F9 RID: 78329 RVA: 0x002C9161 File Offset: 0x002C7361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivateChatOperateType OperateType
		{
			get
			{
				return this.operateType_;
			}
			set
			{
				this.operateType_ = value;
			}
		}

		// Token: 0x17003F72 RID: 16242
		// (get) Token: 0x060131FA RID: 78330 RVA: 0x002C916A File Offset: 0x002C736A
		// (set) Token: 0x060131FB RID: 78331 RVA: 0x002C9172 File Offset: 0x002C7372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TarPlayerId
		{
			get
			{
				return this.tarPlayerId_;
			}
			set
			{
				this.tarPlayerId_ = value;
			}
		}

		// Token: 0x060131FC RID: 78332 RVA: 0x002C917B File Offset: 0x002C737B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivateChatOperateRequest);
		}

		// Token: 0x060131FD RID: 78333 RVA: 0x002C9189 File Offset: 0x002C7389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrivateChatOperateRequest other)
		{
			return other != null && (other == this || (this.OperateType == other.OperateType && this.TarPlayerId == other.TarPlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060131FE RID: 78334 RVA: 0x002C91C8 File Offset: 0x002C73C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OperateType != PrivateChatOperateType.CloseChat)
			{
				num ^= this.OperateType.GetHashCode();
			}
			if (this.TarPlayerId != 0)
			{
				num ^= this.TarPlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060131FF RID: 78335 RVA: 0x002C9226 File Offset: 0x002C7426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013200 RID: 78336 RVA: 0x002C9233 File Offset: 0x002C7433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013201 RID: 78337 RVA: 0x002C923C File Offset: 0x002C743C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TarPlayerId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.TarPlayerId);
			}
			if (this.OperateType != PrivateChatOperateType.CloseChat)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.OperateType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013202 RID: 78338 RVA: 0x002C9298 File Offset: 0x002C7498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OperateType != PrivateChatOperateType.CloseChat)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.OperateType);
			}
			if (this.TarPlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TarPlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013203 RID: 78339 RVA: 0x002C92F0 File Offset: 0x002C74F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PrivateChatOperateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OperateType != PrivateChatOperateType.CloseChat)
			{
				this.OperateType = other.OperateType;
			}
			if (other.TarPlayerId != 0)
			{
				this.TarPlayerId = other.TarPlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013204 RID: 78340 RVA: 0x002C9340 File Offset: 0x002C7540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013205 RID: 78341 RVA: 0x002C934C File Offset: 0x002C754C
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
				if (num != 72U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.OperateType = (PrivateChatOperateType)input.ReadEnum();
					}
				}
				else
				{
					this.TarPlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040075D9 RID: 30169
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075DA RID: 30170
		public const int OperateTypeFieldNumber = 12;

		// Token: 0x040075DB RID: 30171
		private PrivateChatOperateType operateType_;

		// Token: 0x040075DC RID: 30172
		public const int TarPlayerIdFieldNumber = 9;

		// Token: 0x040075DD RID: 30173
		private int tarPlayerId_;
	}
}

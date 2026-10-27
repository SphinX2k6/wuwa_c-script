using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200107E RID: 4222
	public sealed class RoleFlySkinChange : IMessage<RoleFlySkinChange>, IMessage, IEquatable<RoleFlySkinChange>, IDeepCloneable<RoleFlySkinChange>, IBufferMessage
	{
		// Token: 0x060168E4 RID: 92388 RVA: 0x003474F1 File Offset: 0x003456F1
		[NullableContext(1)]
		public static RoleFlySkinChange Create()
		{
			return new RoleFlySkinChange();
		}

		// Token: 0x17004B84 RID: 19332
		// (get) Token: 0x060168E5 RID: 92389 RVA: 0x003474F8 File Offset: 0x003456F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleFlySkinChange> Parser
		{
			get
			{
				return RoleFlySkinChange._parser;
			}
		}

		// Token: 0x17004B85 RID: 19333
		// (get) Token: 0x060168E6 RID: 92390 RVA: 0x003474FF File Offset: 0x003456FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B86 RID: 19334
		// (get) Token: 0x060168E7 RID: 92391 RVA: 0x00347502 File Offset: 0x00345702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFlySkinChange.Descriptor;
			}
		}

		// Token: 0x060168E8 RID: 92392 RVA: 0x00347509 File Offset: 0x00345709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFlySkinChange()
		{
		}

		// Token: 0x060168E9 RID: 92393 RVA: 0x00347511 File Offset: 0x00345711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFlySkinChange(RoleFlySkinChange other) : this()
		{
			this.roleId_ = other.roleId_;
			this.skinId_ = other.skinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060168EA RID: 92394 RVA: 0x00347542 File Offset: 0x00345742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFlySkinChange Clone()
		{
			return new RoleFlySkinChange(this);
		}

		// Token: 0x17004B87 RID: 19335
		// (get) Token: 0x060168EB RID: 92395 RVA: 0x0034754A File Offset: 0x0034574A
		// (set) Token: 0x060168EC RID: 92396 RVA: 0x00347552 File Offset: 0x00345752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17004B88 RID: 19336
		// (get) Token: 0x060168ED RID: 92397 RVA: 0x0034755B File Offset: 0x0034575B
		// (set) Token: 0x060168EE RID: 92398 RVA: 0x00347563 File Offset: 0x00345763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
		{
			get
			{
				return this.skinId_;
			}
			set
			{
				this.skinId_ = value;
			}
		}

		// Token: 0x060168EF RID: 92399 RVA: 0x0034756C File Offset: 0x0034576C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFlySkinChange);
		}

		// Token: 0x060168F0 RID: 92400 RVA: 0x0034757A File Offset: 0x0034577A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFlySkinChange other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.SkinId == other.SkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060168F1 RID: 92401 RVA: 0x003475B8 File Offset: 0x003457B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.SkinId != 0)
			{
				num ^= this.SkinId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060168F2 RID: 92402 RVA: 0x00347610 File Offset: 0x00345810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060168F3 RID: 92403 RVA: 0x0034761D File Offset: 0x0034581D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060168F4 RID: 92404 RVA: 0x00347628 File Offset: 0x00345828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.SkinId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060168F5 RID: 92405 RVA: 0x00347680 File Offset: 0x00345880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.SkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060168F6 RID: 92406 RVA: 0x003476D8 File Offset: 0x003458D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleFlySkinChange other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.SkinId != 0)
			{
				this.SkinId = other.SkinId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060168F7 RID: 92407 RVA: 0x00347728 File Offset: 0x00345928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060168F8 RID: 92408 RVA: 0x00347734 File Offset: 0x00345934
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SkinId = input.ReadInt32();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040086D0 RID: 34512
		private static readonly MessageParser<RoleFlySkinChange> _parser = new MessageParser<RoleFlySkinChange>(() => new RoleFlySkinChange());

		// Token: 0x040086D1 RID: 34513
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086D2 RID: 34514
		public const int RoleIdFieldNumber = 1;

		// Token: 0x040086D3 RID: 34515
		private int roleId_;

		// Token: 0x040086D4 RID: 34516
		public const int SkinIdFieldNumber = 2;

		// Token: 0x040086D5 RID: 34517
		private int skinId_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001123 RID: 4387
	[NetMessage(EMessageId.RollBlockToggleHintRequest)]
	public sealed class RollBlockToggleHintRequest : IMessage<RollBlockToggleHintRequest>, IMessage, IEquatable<RollBlockToggleHintRequest>, IDeepCloneable<RollBlockToggleHintRequest>, IBufferMessage
	{
		// Token: 0x06017704 RID: 96004 RVA: 0x00368C0D File Offset: 0x00366E0D
		[NullableContext(1)]
		public static RollBlockToggleHintRequest Create()
		{
			return new RollBlockToggleHintRequest();
		}

		// Token: 0x17004EBE RID: 20158
		// (get) Token: 0x06017705 RID: 96005 RVA: 0x00368C14 File Offset: 0x00366E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EBF RID: 20159
		// (get) Token: 0x06017706 RID: 96006 RVA: 0x00368C17 File Offset: 0x00366E17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockToggleHintRequest.Descriptor;
			}
		}

		// Token: 0x06017707 RID: 96007 RVA: 0x00368C1E File Offset: 0x00366E1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockToggleHintRequest()
		{
		}

		// Token: 0x06017708 RID: 96008 RVA: 0x00368C26 File Offset: 0x00366E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockToggleHintRequest(RollBlockToggleHintRequest other) : this()
		{
			this.incId_ = other.incId_;
			this.isOpen_ = other.isOpen_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017709 RID: 96009 RVA: 0x00368C57 File Offset: 0x00366E57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockToggleHintRequest Clone()
		{
			return new RollBlockToggleHintRequest(this);
		}

		// Token: 0x17004EC0 RID: 20160
		// (get) Token: 0x0601770A RID: 96010 RVA: 0x00368C5F File Offset: 0x00366E5F
		// (set) Token: 0x0601770B RID: 96011 RVA: 0x00368C67 File Offset: 0x00366E67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17004EC1 RID: 20161
		// (get) Token: 0x0601770C RID: 96012 RVA: 0x00368C70 File Offset: 0x00366E70
		// (set) Token: 0x0601770D RID: 96013 RVA: 0x00368C78 File Offset: 0x00366E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsOpen
		{
			get
			{
				return this.isOpen_;
			}
			set
			{
				this.isOpen_ = value;
			}
		}

		// Token: 0x0601770E RID: 96014 RVA: 0x00368C81 File Offset: 0x00366E81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockToggleHintRequest);
		}

		// Token: 0x0601770F RID: 96015 RVA: 0x00368C8F File Offset: 0x00366E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockToggleHintRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.IsOpen == other.IsOpen && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017710 RID: 96016 RVA: 0x00368CD0 File Offset: 0x00366ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.IsOpen)
			{
				num ^= this.IsOpen.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017711 RID: 96017 RVA: 0x00368D28 File Offset: 0x00366F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017712 RID: 96018 RVA: 0x00368D35 File Offset: 0x00366F35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017713 RID: 96019 RVA: 0x00368D40 File Offset: 0x00366F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.IncId);
			}
			if (this.IsOpen)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.IsOpen);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017714 RID: 96020 RVA: 0x00368D9C File Offset: 0x00366F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.IsOpen)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017715 RID: 96021 RVA: 0x00368DE8 File Offset: 0x00366FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockToggleHintRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.IsOpen)
			{
				this.IsOpen = other.IsOpen;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017716 RID: 96022 RVA: 0x00368E38 File Offset: 0x00367038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017717 RID: 96023 RVA: 0x00368E44 File Offset: 0x00367044
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
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsOpen = input.ReadBool();
					}
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008BE1 RID: 35809
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BE2 RID: 35810
		public const int IncIdFieldNumber = 3;

		// Token: 0x04008BE3 RID: 35811
		private int incId_;

		// Token: 0x04008BE4 RID: 35812
		public const int IsOpenFieldNumber = 13;

		// Token: 0x04008BE5 RID: 35813
		private bool isOpen_;
	}
}

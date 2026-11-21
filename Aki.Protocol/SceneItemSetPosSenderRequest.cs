using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011AE RID: 4526
	[NetMessage(EMessageId.SceneItemSetPosSenderRequest)]
	public sealed class SceneItemSetPosSenderRequest : IMessage<SceneItemSetPosSenderRequest>, IMessage, IEquatable<SceneItemSetPosSenderRequest>, IDeepCloneable<SceneItemSetPosSenderRequest>, IBufferMessage
	{
		// Token: 0x060182BA RID: 99002 RVA: 0x00384EB0 File Offset: 0x003830B0
		[NullableContext(1)]
		public static SceneItemSetPosSenderRequest Create()
		{
			return new SceneItemSetPosSenderRequest();
		}

		// Token: 0x1700516F RID: 20847
		// (get) Token: 0x060182BB RID: 99003 RVA: 0x00384EB7 File Offset: 0x003830B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005170 RID: 20848
		// (get) Token: 0x060182BC RID: 99004 RVA: 0x00384EBA File Offset: 0x003830BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemSetPosSenderRequest.Descriptor;
			}
		}

		// Token: 0x060182BD RID: 99005 RVA: 0x00384EC1 File Offset: 0x003830C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSetPosSenderRequest()
		{
		}

		// Token: 0x060182BE RID: 99006 RVA: 0x00384EC9 File Offset: 0x003830C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSetPosSenderRequest(SceneItemSetPosSenderRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isControl_ = other.isControl_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060182BF RID: 99007 RVA: 0x00384EFA File Offset: 0x003830FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemSetPosSenderRequest Clone()
		{
			return new SceneItemSetPosSenderRequest(this);
		}

		// Token: 0x17005171 RID: 20849
		// (get) Token: 0x060182C0 RID: 99008 RVA: 0x00384F02 File Offset: 0x00383102
		// (set) Token: 0x060182C1 RID: 99009 RVA: 0x00384F0A File Offset: 0x0038310A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17005172 RID: 20850
		// (get) Token: 0x060182C2 RID: 99010 RVA: 0x00384F13 File Offset: 0x00383113
		// (set) Token: 0x060182C3 RID: 99011 RVA: 0x00384F1B File Offset: 0x0038311B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsControl
		{
			get
			{
				return this.isControl_;
			}
			set
			{
				this.isControl_ = value;
			}
		}

		// Token: 0x060182C4 RID: 99012 RVA: 0x00384F24 File Offset: 0x00383124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemSetPosSenderRequest);
		}

		// Token: 0x060182C5 RID: 99013 RVA: 0x00384F32 File Offset: 0x00383132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemSetPosSenderRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsControl == other.IsControl && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060182C6 RID: 99014 RVA: 0x00384F70 File Offset: 0x00383170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.IsControl)
			{
				num ^= this.IsControl.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060182C7 RID: 99015 RVA: 0x00384FC8 File Offset: 0x003831C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060182C8 RID: 99016 RVA: 0x00384FD5 File Offset: 0x003831D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060182C9 RID: 99017 RVA: 0x00384FE0 File Offset: 0x003831E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityId);
			}
			if (this.IsControl)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsControl);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060182CA RID: 99018 RVA: 0x0038503C File Offset: 0x0038323C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.IsControl)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060182CB RID: 99019 RVA: 0x00385088 File Offset: 0x00383288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemSetPosSenderRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.IsControl)
			{
				this.IsControl = other.IsControl;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060182CC RID: 99020 RVA: 0x003850D8 File Offset: 0x003832D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060182CD RID: 99021 RVA: 0x003850E4 File Offset: 0x003832E4
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
				if (num != 112U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsControl = input.ReadBool();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04008FD2 RID: 36818
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FD3 RID: 36819
		public const int EntityIdFieldNumber = 14;

		// Token: 0x04008FD4 RID: 36820
		private long entityId_;

		// Token: 0x04008FD5 RID: 36821
		public const int IsControlFieldNumber = 15;

		// Token: 0x04008FD6 RID: 36822
		private bool isControl_;
	}
}

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009FB RID: 2555
	[NetMessage(EMessageId.MonsterDrownPush)]
	public sealed class MonsterDrownPush : IMessage<MonsterDrownPush>, IMessage, IEquatable<MonsterDrownPush>, IDeepCloneable<MonsterDrownPush>, IBufferMessage
	{
		// Token: 0x0600DFB0 RID: 57264 RVA: 0x0020CA75 File Offset: 0x0020AC75
		[NullableContext(1)]
		public static MonsterDrownPush Create()
		{
			return new MonsterDrownPush();
		}

		// Token: 0x17002D59 RID: 11609
		// (get) Token: 0x0600DFB1 RID: 57265 RVA: 0x0020CA7C File Offset: 0x0020AC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D5A RID: 11610
		// (get) Token: 0x0600DFB2 RID: 57266 RVA: 0x0020CA7F File Offset: 0x0020AC7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterDrownPush.Descriptor;
			}
		}

		// Token: 0x0600DFB3 RID: 57267 RVA: 0x0020CA86 File Offset: 0x0020AC86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDrownPush()
		{
		}

		// Token: 0x0600DFB4 RID: 57268 RVA: 0x0020CA8E File Offset: 0x0020AC8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDrownPush(MonsterDrownPush other) : this()
		{
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DFB5 RID: 57269 RVA: 0x0020CAC3 File Offset: 0x0020ACC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterDrownPush Clone()
		{
			return new MonsterDrownPush(this);
		}

		// Token: 0x17002D5B RID: 11611
		// (get) Token: 0x0600DFB6 RID: 57270 RVA: 0x0020CACB File Offset: 0x0020ACCB
		// (set) Token: 0x0600DFB7 RID: 57271 RVA: 0x0020CAD3 File Offset: 0x0020ACD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x0600DFB8 RID: 57272 RVA: 0x0020CADC File Offset: 0x0020ACDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterDrownPush);
		}

		// Token: 0x0600DFB9 RID: 57273 RVA: 0x0020CAEA File Offset: 0x0020ACEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterDrownPush other)
		{
			return other != null && (other == this || (object.Equals(this.Pos, other.Pos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DFBA RID: 57274 RVA: 0x0020CB20 File Offset: 0x0020AD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DFBB RID: 57275 RVA: 0x0020CB5C File Offset: 0x0020AD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DFBC RID: 57276 RVA: 0x0020CB69 File Offset: 0x0020AD69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DFBD RID: 57277 RVA: 0x0020CB72 File Offset: 0x0020AD72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pos_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Pos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DFBE RID: 57278 RVA: 0x0020CBA4 File Offset: 0x0020ADA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DFBF RID: 57279 RVA: 0x0020CBE4 File Offset: 0x0020ADE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterDrownPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.pos_ != null)
			{
				if (this.pos_ == null)
				{
					this.Pos = new Vector();
				}
				this.Pos.MergeFrom(other.Pos);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DFC0 RID: 57280 RVA: 0x0020CC38 File Offset: 0x0020AE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DFC1 RID: 57281 RVA: 0x0020CC44 File Offset: 0x0020AE44
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.pos_ == null)
					{
						this.Pos = new Vector();
					}
					input.ReadMessage(this.Pos);
				}
			}
		}

		// Token: 0x04005C33 RID: 23603
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C34 RID: 23604
		public const int PosFieldNumber = 4;

		// Token: 0x04005C35 RID: 23605
		private Vector pos_;
	}
}

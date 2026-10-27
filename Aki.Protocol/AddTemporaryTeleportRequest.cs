using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000B1 RID: 177
	[NetMessage(EMessageId.AddTemporaryTeleportRequest)]
	public sealed class AddTemporaryTeleportRequest : IMessage<AddTemporaryTeleportRequest>, IMessage, IEquatable<AddTemporaryTeleportRequest>, IDeepCloneable<AddTemporaryTeleportRequest>, IBufferMessage
	{
		// Token: 0x06001D8D RID: 7565 RVA: 0x0005130C File Offset: 0x0004F50C
		[NullableContext(1)]
		public static AddTemporaryTeleportRequest Create()
		{
			return new AddTemporaryTeleportRequest();
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06001D8E RID: 7566 RVA: 0x00051313 File Offset: 0x0004F513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06001D8F RID: 7567 RVA: 0x00051316 File Offset: 0x0004F516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddTemporaryTeleportRequest.Descriptor;
			}
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x0005131D File Offset: 0x0004F51D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTemporaryTeleportRequest()
		{
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x00051328 File Offset: 0x0004F528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTemporaryTeleportRequest(AddTemporaryTeleportRequest other) : this()
		{
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.rot_ = ((other.rot_ != null) ? other.rot_.Clone() : null);
			this.area_ = other.area_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x00051390 File Offset: 0x0004F590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddTemporaryTeleportRequest Clone()
		{
			return new AddTemporaryTeleportRequest(this);
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06001D93 RID: 7571 RVA: 0x00051398 File Offset: 0x0004F598
		// (set) Token: 0x06001D94 RID: 7572 RVA: 0x000513A0 File Offset: 0x0004F5A0
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

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06001D95 RID: 7573 RVA: 0x000513A9 File Offset: 0x0004F5A9
		// (set) Token: 0x06001D96 RID: 7574 RVA: 0x000513B1 File Offset: 0x0004F5B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator Rot
		{
			get
			{
				return this.rot_;
			}
			set
			{
				this.rot_ = value;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06001D97 RID: 7575 RVA: 0x000513BA File Offset: 0x0004F5BA
		// (set) Token: 0x06001D98 RID: 7576 RVA: 0x000513C2 File Offset: 0x0004F5C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Area
		{
			get
			{
				return this.area_;
			}
			set
			{
				this.area_ = value;
			}
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x000513CB File Offset: 0x0004F5CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddTemporaryTeleportRequest);
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x000513DC File Offset: 0x0004F5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddTemporaryTeleportRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Pos, other.Pos) && object.Equals(this.Rot, other.Rot) && this.Area == other.Area && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x00051440 File Offset: 0x0004F640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this.rot_ != null)
			{
				num ^= this.Rot.GetHashCode();
			}
			if (this.Area != 0)
			{
				num ^= this.Area.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x000514AB File Offset: 0x0004F6AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x000514B8 File Offset: 0x0004F6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x000514C4 File Offset: 0x0004F6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pos_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Pos);
			}
			if (this.rot_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Rot);
			}
			if (this.Area != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Area);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x0005153C File Offset: 0x0004F73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this.rot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rot);
			}
			if (this.Area != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Area);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x000515AC File Offset: 0x0004F7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddTemporaryTeleportRequest other)
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
			if (other.rot_ != null)
			{
				if (this.rot_ == null)
				{
					this.Rot = new Rotator();
				}
				this.Rot.MergeFrom(other.Rot);
			}
			if (other.Area != 0)
			{
				this.Area = other.Area;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x00051640 File Offset: 0x0004F840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x0005164C File Offset: 0x0004F84C
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
				if (num != 10U)
				{
					if (num != 74U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Area = input.ReadInt32();
						}
					}
					else
					{
						if (this.rot_ == null)
						{
							this.Rot = new Rotator();
						}
						input.ReadMessage(this.Rot);
					}
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

		// Token: 0x04002322 RID: 8994
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002323 RID: 8995
		public const int PosFieldNumber = 1;

		// Token: 0x04002324 RID: 8996
		private Vector pos_;

		// Token: 0x04002325 RID: 8997
		public const int RotFieldNumber = 9;

		// Token: 0x04002326 RID: 8998
		private Rotator rot_;

		// Token: 0x04002327 RID: 8999
		public const int AreaFieldNumber = 10;

		// Token: 0x04002328 RID: 9000
		private int area_;
	}
}

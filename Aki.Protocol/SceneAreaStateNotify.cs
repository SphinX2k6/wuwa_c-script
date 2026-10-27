using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001142 RID: 4418
	[NetMessage(EMessageId.SceneAreaStateNotify)]
	public sealed class SceneAreaStateNotify : IMessage<SceneAreaStateNotify>, IMessage, IEquatable<SceneAreaStateNotify>, IDeepCloneable<SceneAreaStateNotify>, IBufferMessage
	{
		// Token: 0x060178EC RID: 96492 RVA: 0x0036B9E3 File Offset: 0x00369BE3
		[NullableContext(1)]
		public static SceneAreaStateNotify Create()
		{
			return new SceneAreaStateNotify();
		}

		// Token: 0x17004F0F RID: 20239
		// (get) Token: 0x060178ED RID: 96493 RVA: 0x0036B9EA File Offset: 0x00369BEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F10 RID: 20240
		// (get) Token: 0x060178EE RID: 96494 RVA: 0x0036B9ED File Offset: 0x00369BED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneAreaStateNotify.Descriptor;
			}
		}

		// Token: 0x060178EF RID: 96495 RVA: 0x0036B9F4 File Offset: 0x00369BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneAreaStateNotify()
		{
		}

		// Token: 0x060178F0 RID: 96496 RVA: 0x0036B9FC File Offset: 0x00369BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneAreaStateNotify(SceneAreaStateNotify other) : this()
		{
			this.areaState_ = ((other.areaState_ != null) ? other.areaState_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060178F1 RID: 96497 RVA: 0x0036BA31 File Offset: 0x00369C31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneAreaStateNotify Clone()
		{
			return new SceneAreaStateNotify(this);
		}

		// Token: 0x17004F11 RID: 20241
		// (get) Token: 0x060178F2 RID: 96498 RVA: 0x0036BA39 File Offset: 0x00369C39
		// (set) Token: 0x060178F3 RID: 96499 RVA: 0x0036BA41 File Offset: 0x00369C41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneAreaState AreaState
		{
			get
			{
				return this.areaState_;
			}
			set
			{
				this.areaState_ = value;
			}
		}

		// Token: 0x060178F4 RID: 96500 RVA: 0x0036BA4A File Offset: 0x00369C4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneAreaStateNotify);
		}

		// Token: 0x060178F5 RID: 96501 RVA: 0x0036BA58 File Offset: 0x00369C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneAreaStateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.AreaState, other.AreaState) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060178F6 RID: 96502 RVA: 0x0036BA8C File Offset: 0x00369C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.areaState_ != null)
			{
				num ^= this.AreaState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060178F7 RID: 96503 RVA: 0x0036BAC8 File Offset: 0x00369CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060178F8 RID: 96504 RVA: 0x0036BAD5 File Offset: 0x00369CD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060178F9 RID: 96505 RVA: 0x0036BADE File Offset: 0x00369CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.areaState_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.AreaState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060178FA RID: 96506 RVA: 0x0036BB10 File Offset: 0x00369D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.areaState_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AreaState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060178FB RID: 96507 RVA: 0x0036BB50 File Offset: 0x00369D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneAreaStateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.areaState_ != null)
			{
				if (this.areaState_ == null)
				{
					this.AreaState = new SceneAreaState();
				}
				this.AreaState.MergeFrom(other.AreaState);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060178FC RID: 96508 RVA: 0x0036BBA4 File Offset: 0x00369DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060178FD RID: 96509 RVA: 0x0036BBB0 File Offset: 0x00369DB0
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.areaState_ == null)
					{
						this.AreaState = new SceneAreaState();
					}
					input.ReadMessage(this.AreaState);
				}
			}
		}

		// Token: 0x04008BE8 RID: 35816
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BE9 RID: 35817
		public const int AreaStateFieldNumber = 15;

		// Token: 0x04008BEA RID: 35818
		private SceneAreaState areaState_;
	}
}

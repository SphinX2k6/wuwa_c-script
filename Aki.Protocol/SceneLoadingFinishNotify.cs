using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011B6 RID: 4534
	[NetMessage(EMessageId.SceneLoadingFinishNotify)]
	public sealed class SceneLoadingFinishNotify : IMessage<SceneLoadingFinishNotify>, IMessage, IEquatable<SceneLoadingFinishNotify>, IDeepCloneable<SceneLoadingFinishNotify>, IBufferMessage
	{
		// Token: 0x0601835A RID: 99162 RVA: 0x00386349 File Offset: 0x00384549
		[NullableContext(1)]
		public static SceneLoadingFinishNotify Create()
		{
			return new SceneLoadingFinishNotify();
		}

		// Token: 0x1700518F RID: 20879
		// (get) Token: 0x0601835B RID: 99163 RVA: 0x00386350 File Offset: 0x00384550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005190 RID: 20880
		// (get) Token: 0x0601835C RID: 99164 RVA: 0x00386353 File Offset: 0x00384553
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneLoadingFinishNotify.Descriptor;
			}
		}

		// Token: 0x0601835D RID: 99165 RVA: 0x0038635A File Offset: 0x0038455A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneLoadingFinishNotify()
		{
		}

		// Token: 0x0601835E RID: 99166 RVA: 0x00386362 File Offset: 0x00384562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneLoadingFinishNotify(SceneLoadingFinishNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601835F RID: 99167 RVA: 0x00386387 File Offset: 0x00384587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneLoadingFinishNotify Clone()
		{
			return new SceneLoadingFinishNotify(this);
		}

		// Token: 0x17005191 RID: 20881
		// (get) Token: 0x06018360 RID: 99168 RVA: 0x0038638F File Offset: 0x0038458F
		// (set) Token: 0x06018361 RID: 99169 RVA: 0x00386397 File Offset: 0x00384597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x06018362 RID: 99170 RVA: 0x003863A0 File Offset: 0x003845A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneLoadingFinishNotify);
		}

		// Token: 0x06018363 RID: 99171 RVA: 0x003863AE File Offset: 0x003845AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneLoadingFinishNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018364 RID: 99172 RVA: 0x003863DC File Offset: 0x003845DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018365 RID: 99173 RVA: 0x0038641B File Offset: 0x0038461B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018366 RID: 99174 RVA: 0x00386428 File Offset: 0x00384628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018367 RID: 99175 RVA: 0x00386431 File Offset: 0x00384631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018368 RID: 99176 RVA: 0x00386464 File Offset: 0x00384664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018369 RID: 99177 RVA: 0x003864A2 File Offset: 0x003846A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneLoadingFinishNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601836A RID: 99178 RVA: 0x003864D3 File Offset: 0x003846D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601836B RID: 99179 RVA: 0x003864DC File Offset: 0x003846DC
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008FFA RID: 36858
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FFB RID: 36859
		public const int PlayerIdFieldNumber = 7;

		// Token: 0x04008FFC RID: 36860
		private int playerId_;
	}
}

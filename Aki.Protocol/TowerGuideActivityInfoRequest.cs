using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200142F RID: 5167
	[NetMessage(EMessageId.TowerGuideActivityInfoRequest)]
	public sealed class TowerGuideActivityInfoRequest : IMessage<TowerGuideActivityInfoRequest>, IMessage, IEquatable<TowerGuideActivityInfoRequest>, IDeepCloneable<TowerGuideActivityInfoRequest>, IBufferMessage
	{
		// Token: 0x0601B75D RID: 112477 RVA: 0x003FE185 File Offset: 0x003FC385
		[NullableContext(1)]
		public static TowerGuideActivityInfoRequest Create()
		{
			return new TowerGuideActivityInfoRequest();
		}

		// Token: 0x17005CFA RID: 23802
		// (get) Token: 0x0601B75E RID: 112478 RVA: 0x003FE18C File Offset: 0x003FC38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CFB RID: 23803
		// (get) Token: 0x0601B75F RID: 112479 RVA: 0x003FE18F File Offset: 0x003FC38F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerGuideActivityInfoRequest.Descriptor;
			}
		}

		// Token: 0x0601B760 RID: 112480 RVA: 0x003FE196 File Offset: 0x003FC396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerGuideActivityInfoRequest()
		{
		}

		// Token: 0x0601B761 RID: 112481 RVA: 0x003FE19E File Offset: 0x003FC39E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerGuideActivityInfoRequest(TowerGuideActivityInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B762 RID: 112482 RVA: 0x003FE1B7 File Offset: 0x003FC3B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerGuideActivityInfoRequest Clone()
		{
			return new TowerGuideActivityInfoRequest(this);
		}

		// Token: 0x0601B763 RID: 112483 RVA: 0x003FE1BF File Offset: 0x003FC3BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerGuideActivityInfoRequest);
		}

		// Token: 0x0601B764 RID: 112484 RVA: 0x003FE1CD File Offset: 0x003FC3CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerGuideActivityInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601B765 RID: 112485 RVA: 0x003FE1EC File Offset: 0x003FC3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B766 RID: 112486 RVA: 0x003FE212 File Offset: 0x003FC412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B767 RID: 112487 RVA: 0x003FE21F File Offset: 0x003FC41F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B768 RID: 112488 RVA: 0x003FE228 File Offset: 0x003FC428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B769 RID: 112489 RVA: 0x003FE240 File Offset: 0x003FC440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B76A RID: 112490 RVA: 0x003FE266 File Offset: 0x003FC466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerGuideActivityInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B76B RID: 112491 RVA: 0x003FE283 File Offset: 0x003FC483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B76C RID: 112492 RVA: 0x003FE28C File Offset: 0x003FC48C
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009FDF RID: 40927
		private UnknownFieldSet _unknownFields;
	}
}

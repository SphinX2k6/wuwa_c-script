using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005C6 RID: 1478
	[NetMessage(EMessageId.FloroRanchPlayRefreshShopRequest)]
	public sealed class FloroRanchPlayRefreshShopRequest : IMessage<FloroRanchPlayRefreshShopRequest>, IMessage, IEquatable<FloroRanchPlayRefreshShopRequest>, IDeepCloneable<FloroRanchPlayRefreshShopRequest>, IBufferMessage
	{
		// Token: 0x06008894 RID: 34964 RVA: 0x001490A7 File Offset: 0x001472A7
		[NullableContext(1)]
		public static FloroRanchPlayRefreshShopRequest Create()
		{
			return new FloroRanchPlayRefreshShopRequest();
		}

		// Token: 0x17001AC8 RID: 6856
		// (get) Token: 0x06008895 RID: 34965 RVA: 0x001490AE File Offset: 0x001472AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001AC9 RID: 6857
		// (get) Token: 0x06008896 RID: 34966 RVA: 0x001490B1 File Offset: 0x001472B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayRefreshShopRequest.Descriptor;
			}
		}

		// Token: 0x06008897 RID: 34967 RVA: 0x001490B8 File Offset: 0x001472B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRefreshShopRequest()
		{
		}

		// Token: 0x06008898 RID: 34968 RVA: 0x001490C0 File Offset: 0x001472C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRefreshShopRequest(FloroRanchPlayRefreshShopRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008899 RID: 34969 RVA: 0x001490FD File Offset: 0x001472FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRefreshShopRequest Clone()
		{
			return new FloroRanchPlayRefreshShopRequest(this);
		}

		// Token: 0x17001ACA RID: 6858
		// (get) Token: 0x0600889A RID: 34970 RVA: 0x00149105 File Offset: 0x00147305
		// (set) Token: 0x0600889B RID: 34971 RVA: 0x0014910D File Offset: 0x0014730D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17001ACB RID: 6859
		// (get) Token: 0x0600889C RID: 34972 RVA: 0x00149116 File Offset: 0x00147316
		// (set) Token: 0x0600889D RID: 34973 RVA: 0x0014911E File Offset: 0x0014731E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubInsId
		{
			get
			{
				return this.subInsId_;
			}
			set
			{
				this.subInsId_ = value;
			}
		}

		// Token: 0x17001ACC RID: 6860
		// (get) Token: 0x0600889E RID: 34974 RVA: 0x00149127 File Offset: 0x00147327
		// (set) Token: 0x0600889F RID: 34975 RVA: 0x0014912F File Offset: 0x0014732F
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

		// Token: 0x060088A0 RID: 34976 RVA: 0x00149138 File Offset: 0x00147338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayRefreshShopRequest);
		}

		// Token: 0x060088A1 RID: 34977 RVA: 0x00149148 File Offset: 0x00147348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayRefreshShopRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060088A2 RID: 34978 RVA: 0x001491A4 File Offset: 0x001473A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.SubInsId != 0)
			{
				num ^= this.SubInsId.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060088A3 RID: 34979 RVA: 0x00149215 File Offset: 0x00147415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060088A4 RID: 34980 RVA: 0x00149222 File Offset: 0x00147422
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060088A5 RID: 34981 RVA: 0x0014922C File Offset: 0x0014742C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.IncId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.SubInsId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060088A6 RID: 34982 RVA: 0x001492A4 File Offset: 0x001474A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubInsId);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060088A7 RID: 34983 RVA: 0x00149314 File Offset: 0x00147514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayRefreshShopRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.SubInsId != 0)
			{
				this.SubInsId = other.SubInsId;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060088A8 RID: 34984 RVA: 0x00149378 File Offset: 0x00147578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060088A9 RID: 34985 RVA: 0x00149384 File Offset: 0x00147584
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
				if (num != 40U)
				{
					if (num != 80U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SubInsId = input.ReadInt32();
						}
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004339 RID: 17209
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400433A RID: 17210
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x0400433B RID: 17211
		private int activityId_;

		// Token: 0x0400433C RID: 17212
		public const int SubInsIdFieldNumber = 15;

		// Token: 0x0400433D RID: 17213
		private int subInsId_;

		// Token: 0x0400433E RID: 17214
		public const int IncIdFieldNumber = 5;

		// Token: 0x0400433F RID: 17215
		private int incId_;
	}
}
